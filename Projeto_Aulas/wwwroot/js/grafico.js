 // Função para criar o gráfico
 function criarGrafico(data) {

    // Obtenha o contexto do elemento canvas
    var ctx = document.getElementById('meuGrafico').getContext('2d');

    // Mapeie os nomes como rótulos e populações como valores
    var nomes = data.map(item => item.nome);
    var populacoes = data.map(item => item.populacao);

    // Crie um novo gráfico
    new Chart(ctx, {
        type: 'pie', // Tipo de gráfico (pode ser 'bar', 'line', 'pie', etc.)
        data: {
            labels: nomes, // Rótulos do eixo X
            datasets: [{
                label: 'População Países',
                data: populacoes, // Valores do eixo Y
            }]
        },
        options: {
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });
}

// Função para fazer uma solicitação AJAX e obter os dados do controlador
function obterDadosParaGrafico() {
    fetch('/Admin/Pais/ObterDadosParaGrafico')
        .then(response => response.json())
        .then(data => {
            // Chame a função criarGrafico com os dados obtidos
            criarGrafico(data);
        });
}

// Chame a função para obter os dados e criar o gráfico
obterDadosParaGrafico();