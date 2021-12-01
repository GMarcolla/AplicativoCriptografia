namespace TesteCriptografia
{
    public partial class Form1 : Form
    {
        private CryptProvider TipoCriptografia;

        public Form1()
        {
            InitializeComponent();            
        }

        private void btnEscolherDocumento_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txDocumento.Text = openFileDialog1.FileName;                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chaveDecript = Microsoft.VisualBasic.Interaction.InputBox("Digite a chave de criptografia", "Chave");
            
            string nomeDocumento = txDocumento.Text.Remove(txDocumento.Text.LastIndexOf('\\') + 1);
            nomeDocumento += $"ArquivoCriptografado{txDocumento.Text.Substring(txDocumento.Text.LastIndexOf('.'))}";

            File.WriteAllBytes(nomeDocumento, EncriptarDocumento(txDocumento.Text, chaveDecript));
        }

        private byte[] EncriptarDocumento(string filePath, string chave)
        {
            Criptografia cript = new Criptografia(TipoCriptografia);
            cript.Key = chave;

            string documento = Convert.ToBase64String(File.ReadAllBytes(filePath));
            byte[] documentoCriptografado = Convert.FromBase64String(cript.Encrypt(documento));

            return documentoCriptografado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chaveDecript = Microsoft.VisualBasic.Interaction.InputBox("Digite a chave de criptografia", "Chave");

            string nomeDocumento = txDocumento.Text.Remove(txDocumento.Text.LastIndexOf('\\') + 1);
            nomeDocumento += $"ArquivoDescriptografado{txDocumento.Text.Substring(txDocumento.Text.LastIndexOf('.'))}";

            byte[] arqDecriptado = DecriptarDocumento(txDocumento.Text, chaveDecript);

            if (arqDecriptado != null)
            {
                File.WriteAllBytes(nomeDocumento, arqDecriptado);
            }
        }

        private byte[] DecriptarDocumento(string filePath, string chave) 
        {            
            string documento = Convert.ToBase64String(File.ReadAllBytes(filePath));

            Criptografia cript = new Criptografia(TipoCriptografia);
            cript.Key = chave;

            try
            {
                return Convert.FromBase64String(cript.Decrypt(documento));
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Chave de descriptografia incorreta");
                return null;
            }
        }

        private void DefinirTipoCriptografia()
        {
            switch (comboBox1.Text) 
            {
                case "DES":
                    TipoCriptografia = CryptProvider.DES;
                    break;
                case "3-DES":
                    TipoCriptografia = CryptProvider.TripleDES;
                    break;
                case "AES":
                    TipoCriptografia = CryptProvider.AES;
                    break;
                default:
                    TipoCriptografia = CryptProvider.DES;
                    break;
            }

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefinirTipoCriptografia();
        }
    }
}