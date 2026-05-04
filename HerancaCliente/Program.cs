using HerancaCliente;

Cliente c1 = new Cliente();

//"Cliente.codigo"
//c1.codigo = 1; protegido pelo private

c1.Codigo = 1;
c1.Nome = "Ana";
c1.MostrarAtributos();

ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Bia"; //Herança aplicada
cf.Rg = 100;
cf.MostrarAtributos();

ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 3;
cj.Nome = "Empresa"; //Heranca aplicada
cj.Cnpj = 1000;
cj.MostrarAtributos();
