const express = require('express');

const app = express()
app.use(express.json())
app.use(express.urlencoded())

app.get('/', (req, res) => {
    res.json({ name: req.query.name }).send();
});

app.listen(3001, console.log("Api rodando na porta 3001"));