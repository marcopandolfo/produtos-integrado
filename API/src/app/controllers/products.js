module.exports = (app) => {
    app.get('/products', (req, res) => {
        res.status(200).send('OK');
    });
};
