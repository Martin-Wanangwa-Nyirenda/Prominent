'use strict'
const path = require('path')
const express = require('express');
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
    return dbCon.getAllProjects(res);
});

app.listen(port, () => {
    console.log("Server listening on port " + port);
})

