//Exercício Calculando a média de 3 notas de um aluno

//Receber o nome do aluno e armazenar em uma variável do tipo string
string aluno = Console.ReadLine();
Console.WriteLine("Informe o nome do aluno:");

//Receber a nota 1, converter e armazenar em uma variável int
Console.WriteLine("Digite a nota 1:");
int nota1 = int.Parse(Console.ReadLine());

//Receber a nota 2, converter e armazenar em uma variável int
Console.WriteLine("Digite a nota 2:");
int nota2 = int.Parse(Console.ReadLine());

//Receber a nota 3, converter e armazenar em uma variável int
Console.WriteLine("Digite a nota 3:");
int nota3 = int.Parse(Console.ReadLine());

//Declarar uma variável do tipo int, para receber a média das notas
// (nota1 + nota2 + nota3) / 3
int media = (nota1 + nota2 + nota3) / 3;

//Exibir uma mensagem se o aluno está aprovado consderando acima de 7
if (media >=7) {
    Console.WriteLine($"{aluno} você está aprovado com média {media} ");
} else {
    Console.WriteLine($"{aluno} você esta REPROVADO com média {media} ");
}
