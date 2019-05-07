/* eslint-disable no-underscore-dangle */
function ProductsDAO(connection) {
    this._connection = connection;
}

ProductsDAO.prototype.save = function save(product, callback) {
    this._connection.query('INSERT INTO products SET ?', product, callback);
};

ProductsDAO.prototype.getAll = function getAll(callback) {
    this._connection.query('SELECT * FROM products', callback);
};

ProductsDAO.prototype.deleteId = function deleteId(id, callback) {
    this._connection.query('DELETE from products where id = ?', [id], callback);
};

// eslint-disable-next-line func-names
module.exports = function () {
    return ProductsDAO;
};
