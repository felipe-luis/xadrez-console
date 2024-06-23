﻿using System;
using tabuleiro;
using xadrez_console;
using xadrez;

try
{

    Tabuleiro tab = new Tabuleiro(8, 8);

    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 8));
    tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));


    Tela.ImprimirTabuleiro(tab);

}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
Console.ReadLine();