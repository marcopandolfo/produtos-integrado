const express = require('express');
const consign = require('consign');
const bodyParser = require('body-parser');
const expressValidator = require('express-validator');
const routes = require('../app/routes/routes');

//App
const app = express();
routes(app);

//BodyParser
app.use(bodyParser.urlencoded({extended: true}));
app.use(bodyParser.json());

//ExpressValidator
app.use(expressValidator());

//Consign

module.exports = app;