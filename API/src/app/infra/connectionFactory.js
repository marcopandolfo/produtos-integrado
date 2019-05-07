/* eslint-disable func-names */
const mysql = require('mysql');

function createDBConnection() {
    return mysql.createConnection({
        host: 'localhost',
        user: 'root',
        password: 'password', // insert you password
        database: 'products',
    });
}

module.exports = function () {
    return createDBConnection;
};
