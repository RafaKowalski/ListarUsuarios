namespace ListarUsuários.Entities
{
    public class Usuarios
    {
        public string Name { get; set; }

        public Usuarios(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return
              "Nome: "
             + Name;
        }
    }
}
