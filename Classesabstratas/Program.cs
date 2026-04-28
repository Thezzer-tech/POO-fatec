using Classesabstratas;

//Cliente c = new Cliente(); dá erro

Endereco e = new Endereco("Rua figueiredo", 10, "Jardim", "PP");

Clientefisico cf = new Clientefisico(1, "Jose", 40, 123232);
cf._Endereco = e;
cf.Mostrar();

Teste teste = new Teste();
teste.AvaliarIdadeCliente(cf);

Clientejuridico cj = new Clientejuridico(1, "EMPRESA", 55, 55555);
cj._Endereco = e;
cj.Mostrar();

teste.AvaliarIdadeCliente(cj);
