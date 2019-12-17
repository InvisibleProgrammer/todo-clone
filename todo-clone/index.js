const express = require('express');
const bodyParser = require('body-parser');

const hostname = '127.0.0.1';
const port = 3000;

const app = express();

var jsonParser = bodyParser.json();
var urlEncodedParser = bodyParser.urlencoded({extended:false});

app.get('/', (req, res) => {
    res.send('Hello World!');
});

app.post('/login', urlEncodedParser, (req, res) => {
    res.send('welcome, ') + req.body.userName;
});

app.listen(port, () => {
    console.log(`Web-Test backend listening on port ${port}!`);
});

