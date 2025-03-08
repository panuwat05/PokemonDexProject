
namespace PokemonDex

{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemonsList = new List<Pokemon>();
        private Pokemon pikachu;
        private Pokemon snorlax;
        private Pokemon charmander;
        private Pokemon seel;
        private Pokemon cubone;
        private Pokemon mewtwo;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// when the form loads, the following code will be executed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Create Pikachu object
            this.pikachu = new Pikachu();
            this.snorlax = new Snorlax();
            this.charmander = new Charmander();
            this.seel = new Seel();
            this.cubone = new Cubone();
            this.mewtwo = new Mewtwo();
            //add Pikachu object to the list
            this.pokemonsList.Add(pikachu);
            this.pokemonsList.Add(snorlax);
            this.pokemonsList.Add(charmander);
            this.pokemonsList.Add(seel);
            this.pokemonsList.Add(cubone);
            this.pokemonsList.Add(mewtwo);
            //display the Pokemon's name and image
            this.pictureBox1.Image = Resource1.TE;


        }
        private void displayPokemon(Pokemon pokemon)
        {
            this.lbPokemonName.Text = pokemon.getName();
            this.lbHP.Text = pokemon.getHP().ToString();
            this.lbAttack.Text = pokemon.getAttack().ToString();
            this.lbDefense.Text = pokemon.getDefense().ToString();
            this.lbSpecialAttack.Text = pokemon.getSpecialAttack().ToString();
            this.lbSpecialDefense.Text = pokemon.getSpecialDefense().ToString();
            this.lbSpeed.Text = pokemon.getSpeed().ToString();
            this.lbHeight.Text = pokemon.getHeight().ToString();
            this.lbWeight.Text = pokemon.getWeight().ToString();
            this.lbTotal.Text = pokemon.getTotal().ToString();
            this.lbType.Text = pokemon.getType().ToString();

            using (var ms = new MemoryStream(pokemon.getImage()))
            {
                this.pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void button4_Click(object sender, EventArgs e) => displayPokemon(this.pikachu);

        private void button1_Click(object sender, EventArgs e) => displayPokemon(this.snorlax);

        private void button2_Click_1(object sender, EventArgs e) => displayPokemon(this.charmander);

        private void button3_Click(object sender, EventArgs e) => displayPokemon(this.seel);

        private void button5_Click(object sender, EventArgs e) => displayPokemon(this.cubone);

        private void button6_Click(object sender, EventArgs e) => displayPokemon(this.mewtwo);

        private void button7_Click(object sender, EventArgs e)
        {
            this.lbPokemonName.Text = "Name";
            this.lbHP.Text = "0";
            this.lbAttack.Text = "0";
            this.lbDefense.Text = "0";
            this.lbSpecialAttack.Text = "0";
            this.lbSpecialDefense.Text = "0";
            this.lbSpeed.Text = "0";
            this.lbHeight.Text = "0";
            this.lbWeight.Text = "0";
            this.lbTotal.Text = "0";
            this.lbType.Text = "Type";

            this.pictureBox1.Image = Resource1.TE; // ล้างรูปภาพ
        }
    
    }
}
