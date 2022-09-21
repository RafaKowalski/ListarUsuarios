using System;
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

            Console.WriteLine("Listando a poderósissima banda Blinks of rage");
            foreach (Usuarios usu in list)
                Console.WriteLine(usu.ToString());

            Console.WriteLine();

            Console.WriteLine("Digite o usuário que deseja remover");
            var removeUsuario = Console.ReadLine();

            Usuarios usuarios = list.Find(x => x.Name == removeUsuario);
            list.Remove(usuarios);

            foreach (Usuarios usu in list)
                Console.WriteLine("Nova lista - " + usu.ToString());
        }
    }
}