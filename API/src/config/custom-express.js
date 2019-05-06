const express = require('express');
const consign = require('consign');
const bodyParser = require('body-parser');
const expressValidator = require('express-validator');

//App
const app = express();

//BodyParser
app.use(bodyParser.urlencoded({extended: true}));
app.use(bodyParser.json());

//ExpressValidator
app.use(expressValidator());

//Consign

module.exports = app;