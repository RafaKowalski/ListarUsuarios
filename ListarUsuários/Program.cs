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

            List<Usuarios> list = new List<Usuarios>();

            for (int i = 1; i <= users; i++)
            {
                Console.WriteLine($"usuário {i}");
                Console.WriteLine("Nome");
                string name = Console.ReadLine();

                list.Add(new Usuarios(name));
            }

            Console.WriteLine("Listando usuários");
            foreach (Usuarios usu in list)
                Console.WriteLine(usu.ToString());

            Console.WriteLine();

            Console.WriteLine("Deseja remover um usuário? S/N");
            string escolha = Console.ReadLine().ToUpper();

            if (escolha == "S")
            {
                Console.WriteLine("Digite o nome do usuário que deseja remover");
                var removeUsuario = Console.ReadLine();

                Usuarios usuarios = list.Find(x => x.Name == removeUsuario);
                list.Remove(usuarios);

                foreach (Usuarios usu in list)
                    Console.WriteLine("Nova lista - " + usu);
            }
            else if (escolha == "N")
            {
                Console.WriteLine("Mantendo usuários");
                foreach (Usuarios usu in list)
                    Console.WriteLine(usu);
            }
        }
    }
}