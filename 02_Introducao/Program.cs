//Somente declaramos a variável com0 inteira e não atribuimos valor
int num1;

//Declarando uma variável do tipo inteira e atribuindo o valor
int num2 = 5;

//Declarando uma variável do tipo string
string nomeAluno;

//Variável do tipo lógico (verdadeiro ou falso)
bool resultado = true;

//Variável dontipo valor com casas decimais - para valores mais precisos
double coordenada = 1.80;

//Variável do tipo decimal - mais usada valor monetário
decimal valor = 1.80M;


int idade = 16;
string nome = "Grazy";
Console.WriteLine($"Meu nome é {nome} e tenho { idade} anos");

Console.WriteLine("Em que cidade você nasceu?");
//Recebendo uma informação do usuário e atribuindo na variável cidade
string cidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {cidade}");

int novaIdade = idade + 5;
int anoNascimento = 2023 - idade;
Console.WriteLine($"Você nasceu em {anoNascimento} e daqui a 5 anos terá {novaIdade}");