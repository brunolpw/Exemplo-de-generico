// See https://aka.ms/new-console-template for more information
using Genericos.Models;

var cliente = new Cliente() {
    Id = 1,
    Nome =  "Fulano",
    Funcao = "Cliente",
};

var gerente = new Gerente() {
    Id = 1,
    Nome = "Ciclano",
    Funcao = "Gerente",
    Salario = 15_000M,
};

Generico(cliente);
Generico(gerente);

void Generico(Pessoa pessoa) {
    
    var type = pessoa.GetType();
    var props = type.GetProperties();

    Console.WriteLine("Propriedades: ");
    foreach (var prop in props) { 
        Console.WriteLine($"- {prop.Name} : {prop.PropertyType}");
    }

    var methodInfo = type.GetMethod("DizNome");
    var methodInfo2 = type.GetMethod("DizFuncao");
    var methodInfo3 = type.GetMethod("ComparaNome");

    var retorno = methodInfo?.Invoke(pessoa, new object[] { "TESTE" });
    var retorno2 = methodInfo2?.Invoke(pessoa, new object[] { });
    var retorno3 = methodInfo3?
        .Invoke(pessoa, new object[] { "CICLANO", StringComparison.OrdinalIgnoreCase }); 

    Console.WriteLine(retorno);
    Console.WriteLine(retorno2);
    Console.WriteLine(retorno3);
    Console.WriteLine();
}