'use strict'
const path = require('path')
const express = require('express');
const mysql = require('mysql');
const app = express();
const bodyParser = require('body-parser');
const DatabaseCon = require('./Core/data/DatabaseCon');
const port = 3000;



app.use(bodyParser.json());
app.use(bodyParser.urlencoded({
    extended: true
}));

const dbCon = new DatabaseCon('localhost', 'root', 'password', 'prod_demo');
dbCon.connect();

app.get('/', function (req, res) {
    let arr = dbCon.getAllProjects();
    
    return res.send('1');
});

app.listen(port, () => {
    console.log("Server listening on port " + port);
})

