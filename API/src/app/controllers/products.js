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
        console.log(req.body);
        req.assert('name', 'Invalid name').notEmpty();
        req.assert('price', 'Invalid price').notEmpty().isFloat();
        req.assert('description', 'Invalid Description').notEmpty();
        req.assert('brand', 'Invalid Brand').notEmpty();

        const errors = req.validationErrors();

        if (errors) {
            res.status(422).send(errors);
            return;
        }

        const product = {
            name: req.body.name,
            price: req.body.price,
            description: req.body.description,
            brand: req.body.brand,
            createdAt: new Date().toLocaleString(),
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
        req.assert('id', 'You must pass a ID').notEmpty();
        const errors = req.validationErrors();
        if (errors) {
            res.status(422).send(errors);
            return;
        }

        const { id } = req.body;

        getProductsDAO().deleteId(id, (err) => {
            if (err) return res.status(500).send(err);

            return res.status(204).send();
        });
    });
};
