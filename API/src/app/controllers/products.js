module.exports = (app) => {
    const getProductsDAO = () => {
        const connection = app.infra.connectionFactory();
        return new app.infra.ProductsDAO(connection);
    };
    const baseUrl = '/products';

    // GET
    app.get(baseUrl, (req, res) => {
        getProductsDAO().getAll((err, result) => {
            if (err) return res.status(500).send(err);

            return res.status(200).send(result);
        });
    });

    // POST NEW
    app.post(baseUrl, (req, res) => {
        const product = {
            name: req.body.name,
            price: req.body.price,
            description: req.body.description,
        };

        getProductsDAO().save(product, (err, result) => {
            if (err) return res.status(500).send(err);

            const info = {
                status: 'CREATED',
                insertId: result.insertId,
            };

            return res.status(201).send({ product, info });
        });
    });

    // DELETE
    app.delete(baseUrl, (req, res) => {
        const { id } = req.body;

        getProductsDAO().deleteId(id, (err) => {
            if (err) return res.status(500).send(err);

            return res.status(204).send();
        });
    });
};
