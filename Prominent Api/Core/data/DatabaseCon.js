'use strict'

const mysql = require('mysql');

class DatabaseCon{
    constructor(host, user, password, database){
        this.host = host;
        this.user = user;
        this.password = password;
        this.database = database;
        this.connection = mysql.createConnection({
            host : host,
            user : user,
            password : password,
            database : database
        });       
    }

    connect(){
        this.connection.connect();
    }

    getAllProjects() {
        let isDone = false;
        let arr = [];
        this.connection.query('SELECT * FROM projects', function(error, results){
            if (error) throw error; 
            arr = results.map(x => x);
            isDone = true;
        }); 

        while (isDone == false) {er
            setTimeout(() => { return 0; }, 500);
        }
        return arr;    
    }
}

module.exports = DatabaseCon;