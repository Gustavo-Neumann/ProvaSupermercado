using ProvaPOO2;

Carrinho carrinho = new Carrinho();

Pessoa pessoa = new Pessoa("bonita", 1233231, 130.00f, carrinho);

alimenticio maca = new alimenticio("maca", "natural daora", 10.00f, 8.00f, 20);
alimenticio pera = new alimenticio("pera", "natural daora", 15.00f, 5.00f, 39);
eletronico liquidificador = new eletronico("liquidificador", "eletrolux", 90.00f, 20.00f, 50);
eletronico geladeira = new eletronico("geladeira duas portas", "brastemp", 120.00f, 90.00f, 120);

pessoa.adicionar(geladeira);
pessoa.remover(maca);
pessoa.adicionar(maca);
pessoa.listar();
pessoa.finalizar();


