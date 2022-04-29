﻿using System;
using ListarUsuários.Entities;

namespace ListarUsuario
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o numero de usuarios que deseja listar: ");
            int users = int.Parse(Console.ReadLine());

            List <Usuarios> list = new List<Usuarios>();

            for (int i = 1; i <= users; i++)
            {
                Console.WriteLine($"usuário {i}");
                Console.WriteLine("Nome");
                string name = Console.ReadLine();

                list.Add(new Usuarios(name));
            }

            Console.WriteLine("Lista de todos os usuário");
            foreach (Usuarios usu in list)
                Console.WriteLine(usu.ToString());
        }
    }
}