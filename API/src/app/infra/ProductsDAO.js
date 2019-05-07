/* eslint-disable func-names */
/* eslint-disable no-underscore-dangle */
function ProductsDAO(connection) {
    this._connection = connection;
}

ProductsDAO.prototype.save = function (product, callback) {
    this._connection.query('INSERT INTO products SET ?', product, callback);
};

ProductsDAO.prototype.getAll = function (callback) {
    this._connection.query('SELECT * FROM products', callback);
};

ProductsDAO.prototype.delete = function (id, callback) {
    this._connection.query('DELETE * from products where id = ?', [id], callback);
};

module.exports = function () {
    return ProductsDAO;
};
