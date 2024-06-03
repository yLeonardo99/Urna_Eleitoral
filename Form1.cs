namespace UrnaEletronica
{
    public partial class Form1 : Form
    {
        private List<TextBox> inputs = new List<TextBox>();
        private List<Step> steps = new List<Step>();

        private Dictionary<int, Candidate> candidates = new Dictionary<int, Candidate>();
        private Dictionary<Position, int> nullVotes = new Dictionary<Position, int>();
        private Dictionary<Position, int> whiteVotes = new Dictionary<Position, int>();

        private int indexStep = 0;
        private int indexDigit = 0;

        public Form1()
        {
            InitializeComponent();
            start();
        }

        private void startCandidates()
        {
            candidates.Add(6666, new Candidate(6666, "Paulo Sanges", "UNINOVE", Properties.Resources.paulo, Position.DF));

            candidates.Add(2424, new Candidate(2424, "Eduardo Maciel", "UNINOVE", Properties.Resources.eduardo, Position.DF));

            candidates.Add(77777, new Candidate(77777, "Kell", "SERIE", Properties.Resources.Kel, Position.DE));

            candidates.Add(28288, new Candidate(28288, "Pablo Marçal", "Charlatão", Properties.Resources.marçal, Position.DE));

            candidates.Add(321, new Candidate(321, "Caramelo", "DARUA", Properties.Resources.caramelo, Position.SE));

            candidates.Add(212, new Candidate(212, "Victor", "UNINOVE", Properties.Resources.victor, Position.SE));

            candidates.Add(215, new Candidate(215, "Kenan", "SERIE", Properties.Resources.Kenan, Position.SE));

            candidates.Add(21, new Candidate(21, "Chico Moedas", "BARZINHO", Properties.Resources.chico, Position.GO));

            candidates.Add(66, new Candidate(66, "Paulinho", "UNINOVE", Properties.Resources.paulinho, Position.PR));

            candidates.Add(25, new Candidate(25, "Leonardo Cassiano", "UNINOVE", Properties.Resources.leo, Position.PR));
        }

        private void startInputs()
        {
            inputs.Add(txt_1);
            inputs.Add(txt_2);
            inputs.Add(txt_3);
            inputs.Add(txt_4);
            inputs.Add(txt_5);
        }

        private void startVotes()
        {
            nullVotes.Add(Position.DF, 0);
            nullVotes.Add(Position.DE, 0);
            nullVotes.Add(Position.SE, 0);
            nullVotes.Add(Position.GO, 0);
            nullVotes.Add(Position.PR, 0);

            whiteVotes.Add(Position.DF, 0);
            whiteVotes.Add(Position.DE, 0);
            whiteVotes.Add(Position.SE, 0);
            whiteVotes.Add(Position.GO, 0);
            whiteVotes.Add(Position.PR, 0);
        }

        private void startSteps()
        {
            steps.Add(new Step(4, "Deputado Federal", Position.DF));
            steps.Add(new Step(5, "Deputado Estadual", Position.DE));
            steps.Add(new Step(3, "Senador", Position.SE));
            steps.Add(new Step(2, "Governador", Position.GO));
            steps.Add(new Step(2, "Presidente", Position.PR));
        }

        private void start()
        {
            startCandidates();
            startSteps();
            startInputs();
            startVotes();

            showAndHideDigitsAndResetTitle();
        }

        private Step getCurrentStep()
        {
            return steps[indexStep];
        }

        private void confirmVoteAndGoToNextStep()
        {
            if (hasEmptySomeDigits()) return;

            addVote();
            goToNextStep();
        }

        private void goToNextStep()
        {
            indexStep++;

            if (indexStep >= steps.Count) indexStep = 0;

            showAndHideDigitsAndResetTitle();
        }

        private void addVote()
        {
            Step step = getCurrentStep();
            Candidate? candidate = getCandidate();

            if (candidate == null)
            {
                addNullVote();
                return;
            }

            candidate.addVote();
        }

        private void addNullVote()
        {
            Step step = getCurrentStep();

            nullVotes[step.position]++;
        }

        private void addWhiteVote()
        {
            Step step = getCurrentStep();

            whiteVotes[step.position]++;
        }

        public void showAndHideDigitsAndResetTitle()
        {
            Step step = getCurrentStep();

            for (int i = 0; i < inputs.Count; i++)
            {
                inputs[i].Visible = true;
            }

            for (int i = step.digits; i < inputs.Count; i++)
            {
                inputs[i].Visible = false;
            }

            lbl_info.Text = step.title;
            lbl_nome.Text = "";
            lbl_partido.Text = "";
            pb_img.Image = null;
            pb_img.Visible = false;

            resetDigits();
        }

        public int getDigitsFrom(Step step)
        {
            string digits = "";

            for (int i = 0; i < step.digits; i++)
            {
                digits += inputs[i].Text;
            }

            return Int32.Parse(digits);
        }

        public bool hasEmptySomeDigits()
        {
            Step step = getCurrentStep();

            for (int i = 0; i < step.digits; i++)
            {
                if (inputs[i].Text == "") return true;
            }

            return false;
        }

        private void resetDigits()
        {
            indexDigit = 0;

            foreach (TextBox input in inputs)
            {
                input.Text = "";
            }
        }

        private void setDigit(int digit)
        {
            if (indexDigit < 0 || indexDigit >= steps.Count) return;

            TextBox input = inputs[indexDigit];

            input.Text = digit.ToString();

            verifySelectedCandidate();

            indexDigit++;
        }

        private void verifySelectedCandidate()
        {
            Step step = getCurrentStep();

            if (indexDigit != step.digits - 1) return;

            Candidate? candidate = getCandidate();

            if (candidate == null)
            {
                lbl_nome.Text = "Nulo";
                lbl_partido.Text = "";
                pb_img.Image = null;
                pb_img.Visible = false;
                return;
            }

            lbl_nome.Text = "Nome: " + candidate.name;
            lbl_partido.Text = "Partido: " + candidate.party;
            pb_img.Image = candidate.image;
            pb_img.Visible = true;
        }

        private Candidate? getCandidate()
        {
            Step step = getCurrentStep();

            if (indexDigit != step.digits - 1) return null;

            int digits = getDigitsFrom(step);

            if (!candidates.ContainsKey(digits) || candidates[digits].position != step.position)
            {
                return null;
            }

            return candidates[digits];
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            setDigit(1);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            setDigit(2);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            setDigit(3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            setDigit(4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            setDigit(5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            setDigit(6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            setDigit(7);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            setDigit(8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            setDigit(9);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            setDigit(0);
        }

        private void btn_branco_Click(object sender, EventArgs e)
        {
            addWhiteVote();
            goToNextStep();
        }

        private void btn_corrige_Click(object sender, EventArgs e)
        {
            showAndHideDigitsAndResetTitle();
            resetDigits();
        }

        private void btn_confirma_Click(object sender, EventArgs e)
        {
            confirmVoteAndGoToNextStep();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}