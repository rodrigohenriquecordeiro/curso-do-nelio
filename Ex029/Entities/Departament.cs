namespace ExerciciosDeFixacao10.Entities
{
    class Departament
    {
        public string Name { get; set; }

        //Construtor Padrão
        public Departament()
        {
            
        }

        public Departament(string name)
        {
            Name = name;
        }

    }
}
