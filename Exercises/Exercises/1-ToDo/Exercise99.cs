
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercises
{
    public class Exercise99
    {
        public readonly string description = "99) gerados pelo computador. Logo em seguida, mostre os" +
			"números gerados e depois coloque o vetor em ordem crescente, mostrando no final" +
			"os valores ordenados." +
			"84) Crie um programa que leia o nome e a idade de 9 pessoas e guarde esses" +
			"valores em dois vetores, em posições relacionadas. No final, mostre uma listagem" +
			"contendo apenas os dados das pessoas menores de idade." +
			"85) Faça um algoritmo que leia o nome, o sexo e o salário de 5 funcionários e" +
			"guarde esses dados em três vetores. No final, mostre uma listagem contendo" +
			"apenas os dados das funcionárias mulheres que ganham mais de R$5 mil." +
			"PASSO 09 – PROCEDIMENTOS" +
			"86) Crie um programa que tenha um procedimento Gerador() que, quando chamado," +
			"mostre a mensagem 'Olá, Mundo!' com algum componente visual (linhas)" +
			"Ex: Ao chamar Gerador() aparece:" +
			"+-------=======------+" +
			" Olá, Mundo!" +
			"+-------=======------+" +
			"87) Crie um programa que melhore o procedimento Gerador() da questão anterior" +
			"para que mostre uma mensagem personalizada, passada como parâmetro." +
			"Ex: Ao chamar Gerador('Aprendendo Portugol') aparece:" +
			"+-------=======------+" +
			" Aprendendo Portugol" +
			"+-------=======------+" +
			"88) Crie um programa que melhore o procedimento Gerador() da questão anterior" +
			"para que mostre uma mensagem vário" +
			"Ex: Ao chamar Gerador('Aprendendo Portugol', 4) aparece:" +
			"+-------=======------+" +
			" Aprendendo Portugol" +
			" Aprendendo Portugol" +
			" Aprendendo Portugol" +
			" Aprendendo Portugol" +
			"+-------=======------+" +
			"89) Crie um programa que melhore o procedimento Gerador() da questão anterior" +
			"para que o programador possa escolher uma entre três bordas:" +
			" +-------=======------+ Borda 1" +
			" ~~~~~~~~:::::::~~~~~~~ Borda 2" +
			" <<<<<<<<------->>>>>>> Borda 3" +
			"Ex: Uma chamada válida seria Gerador('Portugol Studio', 3, 2)" +
			"~~~~~~~~:::::::~~~~~~~" +
			" Portugol Studio" +
			" Portugol Studio" +
			" Portugol Studio" +
			"~~~~~~~~:::::::~~~~~~~" +
			"90) Desenvolva um algoritmo que leia dois valores pelo teclado e passe esses" +
			"valores para um procedimento Somador() que vai calcular e mostrar a soma entre" +
			"eles." +
			"91) Desenvolva um algoritmo que leia dois valores pelo teclado e passe esses" +
			"valores para um procedimento Maior() que vai verificar qual deles é o maior e" +
			"mostrá-lo na tela. Caso os dois valores sejam iguais, mostrar uma mensagem" +
			"informando essa característica." +
			"92) Crie uma lógica que leia um número inteiro e passe para um procedimento" +
			"ParOuImpar() que vai verificar e mostrar na tela se o valor passado como" +
			"parâmetro é PAR ou ÍMPAR." +
			"93) Faça um programa que tenha um procedimento chamado Contador() que recebe" +
			"três valores como parâmetro: o início, o fim e o incremento de uma contagem. O" +
			"programa principal deve solicitar a digitação desses valores e passá-los ao" +
			"procedimento, que vai mostrar a contagem na tela." +
			"Ex: Para os valores de início (4), fim (20) e incremento(3) teremos" +
			"Contador(4, 20, 3) vai mostrar na tela 4 >> 7 >> 10 >> 13 >> 16 >> 19 >> FIM" +
			"94) [DESAFIO] Desenvolva um aplicativo que tenha um procedimento chamado" +
			"Fibonacci() que recebe um único valor inteiro como parâmetro, indicando quantos" +
			"termos da sequência serão mostrados na tela. O seu procedimento deve receber" +
			"esse valor e mostrar a quantidade de elementos solicitados." +
			"Obs: Use os exercícios 70 e 75 para te ajudar na solução" +
			"Ex:" +
			"Fibonacci(5) vai gerar 1 >> 1 >> 2 >> 3 >> 5 >> FIM" +
			"Fibonacci(9) vai gerar 1 >> 1 >> 2 >> 3 >> 5 >> 8 >> 13 >> 21 >> 34 >> FIM" +
			"PASSO 10 – FUNÇÕES" +
			"95) Refaça o exercício 90, só que agora em forma de função Somador(), que vai" +
			"receber dois parâmetros e vai retornar o resultado da soma entre eles para o" +
			"programa principal." +
			"96) Crie um programa que tenha uma função Media(), que vai receber as 2 notas de" +
			"um aluno e retornar a sua média para o programa principal." +
			"97) Refaça o exercício 91, só que agora em forma de função Maior(), mas faça uma" +
			"adaptação que vai receber TRÊS números como parâmetro e vai retornar qual foi o" +
			"maior entre eles." +
			"98) Crie um programa que tenha uma função SuperSomador(), que vai receber dois" +
			"números como parâmetro e depois vai retornar a soma de todos os valores no" +
			"intervalo entre os valores recebidos." +
			"Ex:" +
			"SuperSomador(1, 6) vai somar 1 + 2 + 3 + 4 + 5 + 6 e vai retornar 21" +
			"SuperSomador(15, 19) vai somar 15 + 16 + 17 + 18 + 19 e vai retornar 85" +
			"99) Faça um programa que possua uma função chamada Potencia(), que vai receber" +
			"dois parâmetros numéricos (base e expoente) e vai calcular o resultado da" +
			"exponenciação." +
			"Ex: Potencia(5,2) vai calcular 52 = 25";
    }
}        
