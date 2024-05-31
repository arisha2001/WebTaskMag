// using System;
// using System.Text;
// using System.Threading;
// using System.Threading.Tasks;
// using RabbitMQ.Client;
// using RabbitMQ.Client.Events;

// namespace Server.Services
// {
//     public class MessageProducer : IMessageProducer
//     {
//         public static event Func<string, Task> MessageReceived;

//         public async void Setup(CancellationToken cancellationToken)
//         {
//             var factory = new ConnectionFactory() {
//                 HostName = "rabbit",
//                 Port = 5672,
//                 UserName = "guest", 
//                 Password = "guest"
//             };
//             using (var connection = factory.CreateConnection())
//             using (var channel = connection.CreateModel())
//             {
//                 channel.QueueDeclare(
//                     queue: "users",
//                     exclusive: false, 
//                     autoDelete: false,
//                     arguments: null
//                 );

//                 var consumer = new EventingBasicConsumer(channel);
//                 consumer.Received += (model, ea) =>
//                 {
//                     var body = ea.Body.ToArray();
//                     var message = Encoding.UTF8.GetString(body);
//                     MessageReceived.Invoke(message);
//                 };
//                 channel.BasicConsume(queue: "user-queue",
//                                     autoAck: true,
//                                     consumer: consumer);

//                 while (!cancellationToken.IsCancellationRequested)
//                 {
//                     await Task.Delay(1000);
//                 }
//             }

//         }
//     }
// }
 