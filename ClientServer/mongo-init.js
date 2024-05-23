db.createUser(
    {
        user: "admin",
        pwd: "12345",
        roles: [
            {
                role: "readWrite",
                db: "clients"
            }
        ]
    }
);

db = new Mongo().getDB("clients");

db.createCollection('clients_info', { capped: false });
db.clients_info.insert( { name: "aina", email: "email", password: "password" } );