namespace Asynchronous_Programming
{
    public partial class Form1 : Form
    {

        string filenameOne;
        string filenameTwo;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnBook1_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Please choose a file to use for Book 1.", "Select file", MessageBoxButtons.OK);
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                filenameOne = ofd.FileName;
                txtBookOne.Text = ofd.FileName.Split("\\").LastOrDefault();
            }


        }

        private void btnBookTwo_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Please choose a file to use for Book 2.", "Select file", MessageBoxButtons.OK);
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                filenameTwo = ofd.FileName;
                txtBookTwo.Text = ofd.FileName.Split("\\").LastOrDefault();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            lstBox1.Items.Clear();
            lstBox2.Items.Clear();

            List<Task> tasks = new List<Task>();

            var wordTask = ReadBook(filenameOne);
            var wordTask2 = ReadBook2(filenameTwo);

            tasks.Add(wordTask);
            tasks.Add(wordTask2);

            await Task.WhenAll(tasks);
        }


        // Dinesh Adhikari
        private async Task ReadBook2(string filenameTwo)
        {
            var lines = await Task.FromResult(File.ReadAllLinesAsync(filenameTwo));
            var linesWithoutPunctuation = lines.Result.Where(x => x != string.Empty)
                .AsParallel().Select(x => x.ToLower().Trim().Replace(",", "")
                .Replace("*", "").Replace(".", ""));
            var arrayOfWords = linesWithoutPunctuation.SelectMany(x => x.Split(" "));
            Dictionary<string, int> dictionaryOfWords = new Dictionary<string, int>();
            foreach (var word in arrayOfWords)
            {
                if (dictionaryOfWords.ContainsKey(word))
                {
                    dictionaryOfWords[word]++;
                }
                else
                {
                    dictionaryOfWords.Add(word, 1);
                }
            }

            var top10 = dictionaryOfWords.Where(x => !string.IsNullOrWhiteSpace(x.Key))
                .OrderByDescending(x => x.Value).Take(10);

            foreach (var word in top10)
            {
                lstBox2.Items.Add(word.Key + " - " + word.Value);
            }
        }


         // Dinesh Adhikari
        private async Task ReadBook(string filenameOne)
        {
            var lines = await Task.FromResult(File.ReadAllLinesAsync(filenameOne));
            var linesWithoutPunctuation = lines.Result.Where(x => x != string.Empty)
                .AsParallel().Select(x => x.ToLower().Trim().Replace(",", "")
                .Replace("*", "").Replace(".", ""));
            var arrayOfWords = linesWithoutPunctuation.SelectMany(x => x.Split(" "));
            Dictionary<string, int> dictionaryOfWords = new Dictionary<string, int>();
            foreach (var word in arrayOfWords)
            {
                if (dictionaryOfWords.ContainsKey(word))
                {
                    dictionaryOfWords[word]++;
                }
                else
                {
                    dictionaryOfWords.Add(word, 1);
                }
            }

            var top10 = dictionaryOfWords.Where(x => !string.IsNullOrWhiteSpace(x.Key))
                .OrderByDescending(x => x.Value).Take(10);

            foreach (var word in top10)
            {
                lstBox1.Items.Add(word.Key + " - " + word.Value);
            }
        }
    }
}