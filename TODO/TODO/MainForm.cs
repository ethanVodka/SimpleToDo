using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TODO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //フォーム表示時処理
            comboBox_week.SelectedIndex = 0;

            ReadSavedData();
        }

        /// <summary>
        /// ToDoリスト追加処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            String selectWeek;
            String content;

            selectWeek = comboBox_week.Text;
            content = richTextBox_content.Text;

            //week初期値
            ClassProject.Weeks week = ClassProject.Weeks.Monday;

            //データ挿入
            switch (selectWeek)
            {
                case "Monday":
                    week = ClassProject.Weeks.Monday;
                    break;
                case "Tuesday":
                    week = ClassProject.Weeks.Tuesday;
                    break;
                case "Wednesday":
                    week = ClassProject.Weeks.Wednesday;
                    break;
                case "Thursday":
                    week = ClassProject.Weeks.Thursday;
                    break;
                case "Friday":
                    week = ClassProject.Weeks.Friday;
                    break;
                case "Saturday":
                    week = ClassProject.Weeks.Saturday;
                    break;
                case "Sunday":
                    week = ClassProject.Weeks.Sunday;
                    break;
                default:
                    break;
            }

            //dgvへ入力データ出力
            AddToDataGridView(content, week);
            //構造体へ一時的にデータ保存
            AddToDoData(week, content);
            //入力後表示削除
            richTextBox_content.Text = null;
        }

        /// <summary>
        /// dataGridViewへ書き出す処理
        /// </summary>
        /// <param name="todo"></param>
        /// <param name="weeks"></param>
        private void AddToDataGridView(String todo, ClassProject.Weeks weeks)
        {
            switch (weeks)
            {
                case ClassProject.Weeks.Monday:
                    dataGridViewMon.Rows.Add();
                    dataGridViewMon.Rows[dataGridViewMon.RowCount - 1].Cells[0].Value = todo;

                    tabControlWeeks.SelectedTab = pageMon;
                    break;
                case ClassProject.Weeks.Tuesday:
                    dataGridViewTue.Rows.Add();
                    dataGridViewTue.Rows[dataGridViewTue.RowCount - 1].Cells[0].Value = todo;

                    tabControlWeeks.SelectedTab = pageTue;
                    break;
                case ClassProject.Weeks.Wednesday:
                    dataGridViewWed.Rows.Add();
                    dataGridViewWed.Rows[dataGridViewWed.RowCount - 1].Cells[0].Value = todo;

                    tabControlWeeks.SelectedTab = pageWed;
                    break;
                case ClassProject.Weeks.Thursday:
                    dataGridViewThu.Rows.Add();
                    dataGridViewThu.Rows[dataGridViewThu.RowCount - 1].Cells[0].Value = todo;

                    tabControlWeeks.SelectedTab = pageThu;
                    break;
                case ClassProject.Weeks.Friday:
                    dataGridViewFri.Rows.Add();
                    dataGridViewFri.Rows[dataGridViewFri.RowCount - 1].Cells[0].Value = todo;

                    tabControlWeeks.SelectedTab = pageFri;
                    break;
                case ClassProject.Weeks.Saturday:
                    dataGridViewSat.Rows.Add();
                    dataGridViewSat.Rows[dataGridViewSat.RowCount - 1].Cells[0].Value = todo;

                    tabControlWeeks.SelectedTab = pageSat;
                    break;
                case ClassProject.Weeks.Sunday:
                    dataGridViewSun.Rows.Add();
                    dataGridViewSun.Rows[dataGridViewSun.RowCount - 1].Cells[0].Value = todo;

                    tabControlWeeks.SelectedTab = pageSun;
                    break;
            }
        }

        /// <summary>
        /// 保存済みデータの読み出し処理
        /// </summary>
        private void ReadSavedData()
        {
            String tempPath = "todoList.txt";
            System.IO.FileInfo file = new System.IO.FileInfo(tempPath);

            if (!file.Exists) 
            {
                return;
            }

            StreamReader sr = new(tempPath);

            List<String>? contents = new();
            ClassProject.Weeks week = ClassProject.Weeks.Monday;

            while (sr.EndOfStream == false)
            {
                String? line = sr.ReadLine();

                if (line == "###")
                {
                    if (contents.Count != 0)
                    {
                        ProjectGlobal.ToDoList.Add(new ClassProject(week, contents));

                        contents = new List<String>();
                    }
                }
                else
                {
                    switch (line)
                    {
                        case "Monday":
                            week = ClassProject.Weeks.Monday;
                            break;
                        case "Tuesday":
                            week = ClassProject.Weeks.Tuesday;
                            break;
                        case "Wednesday":
                            week = ClassProject.Weeks.Wednesday;
                            break;
                        case "Thursday":
                            week = ClassProject.Weeks.Thursday;
                            break;
                        case "Friday":
                            week = ClassProject.Weeks.Friday;
                            break;
                        case "Saturday":
                            week = ClassProject.Weeks.Saturday;
                            break;
                        case "Sunday":
                            week = ClassProject.Weeks.Sunday;
                            break;
                        default:
                            if (line != null) contents.Add(line);
                            break;
                    }
                }
            }

            sr.Close();

            for (int i = 0; i < ProjectGlobal.ToDoList.Count; i++)
            {
                DataGridView dgv = new();
                switch (ProjectGlobal.ToDoList[i].week)
                {
                    case ClassProject.Weeks.Monday:
                        dgv = dataGridViewMon;
                        break;
                    case ClassProject.Weeks.Tuesday:
                        dgv = dataGridViewTue;
                        break;
                    case ClassProject.Weeks.Wednesday:
                        dgv = dataGridViewWed;
                        break;
                    case ClassProject.Weeks.Thursday:
                        dgv = dataGridViewThu;
                        break;
                    case ClassProject.Weeks.Friday:
                        dgv = dataGridViewFri;
                        break;
                    case ClassProject.Weeks.Saturday:
                        dgv = dataGridViewSat;
                        break;
                    case ClassProject.Weeks.Sunday:
                        dgv = dataGridViewSun;
                        break;
                }
                for (int j = 0; j < ProjectGlobal.ToDoList[i].contents.Count; j++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.RowCount - 1].Cells[0].Value = ProjectGlobal.ToDoList[i].contents[j];
                }
            }

            MessageBox.Show("読み込み完了");
        }

        /// <summary>
        /// グローバル構造体にデータ格納処理
        /// </summary>
        /// <param name="week"></param>
        /// <param name="content"></param>
        private static void AddToDoData(ClassProject.Weeks week, String content)
        {
            bool isNew = true;
            int atIndex = 0;

            for (int i = 0; i < ProjectGlobal.ToDoList.Count; i++)
            {
                if (ProjectGlobal.ToDoList[i].week == week)
                {
                    isNew = false;
                    atIndex = i;
                    break;
                }
                else
                {
                    //...
                }
            }

            if (isNew)
            {
                //Contents co_ = new Contents(content);
                ClassProject clTodo_ = new(week, content);


                ProjectGlobal.ToDoList.Add(clTodo_);
            }
            else
            {
                ProjectGlobal.ToDoList[atIndex].contents.Add(content);
            }

        }

        /// <summary>
        /// 保存処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tempPath = "todoList.txt";
            StreamWriter sw = new(tempPath, false, Encoding.UTF8);

            for (int i = 0; i < ProjectGlobal.ToDoList.Count; i++)
            {
                sw.WriteLine(ProjectGlobal.ToDoList[i].week);
                for (int j = 0; j < ProjectGlobal.ToDoList[i].contents.Count; j++)
                {
                    sw.WriteLine(ProjectGlobal.ToDoList[i].contents[j]);
                }
                sw.WriteLine("###");
            }

            sw.Close();
            MessageBox.Show("保存完了");
        }

        /// <summary>
        /// アプリケーション終了処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.PerformClick();

            this.Close();
        }

        /// <summary>
        /// 削除処理
        /// DataGridViewのセルを選択状態でクリックすると削除できる
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DataGridView dgv = new();
            ClassProject.Weeks week = ClassProject.Weeks.Monday;

            if (tabControlWeeks.SelectedTab == pageMon)
            { 
                dgv = dataGridViewMon; 
                week= ClassProject.Weeks.Monday;
            }
            else if (tabControlWeeks.SelectedTab == pageTue) 
            {
                dgv = dataGridViewTue;
                week = ClassProject.Weeks.Tuesday;
            }
            else if (tabControlWeeks.SelectedTab == pageWed) 
            {
                dgv = dataGridViewWed;
                week = ClassProject.Weeks.Wednesday;
            }
            else if (tabControlWeeks.SelectedTab == pageThu) 
            {
                dgv = dataGridViewThu; 
                week= ClassProject.Weeks.Thursday;
            }
            else if (tabControlWeeks.SelectedTab == pageFri)
            {
                dgv = dataGridViewFri;
                week = ClassProject.Weeks.Friday;
            }
            else if (tabControlWeeks.SelectedTab == pageSat) 
            { 
                dgv = dataGridViewSat;
                week = ClassProject.Weeks.Saturday;
            }
            else if (tabControlWeeks.SelectedTab == pageSun) 
            { 
                dgv = dataGridViewSun; 
                week= ClassProject.Weeks.Sunday;
            }
            else
            {
                //...
            }


            for (int i = 0; i < ProjectGlobal.ToDoList.Count; i++)
            {
                if (ProjectGlobal.ToDoList[i].week == week)
                {
                    ProjectGlobal.ToDoList[i].contents.RemoveAt(dgv.CurrentCell.RowIndex);
                }
            }

            dgv.Rows.RemoveAt(dgv.CurrentCell.RowIndex);
        }

        /// <summary>
        /// データ一斉削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefleshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectGlobal.ToDoList.Clear();

            dataGridViewMon.Rows.Clear();
            dataGridViewTue.Rows.Clear();
            dataGridViewWed.Rows.Clear();
            dataGridViewThu.Rows.Clear();
            dataGridViewFri.Rows.Clear();
            dataGridViewSat.Rows.Clear();
            dataGridViewSun.Rows.Clear();

            String tempPath = "todoList.txt";
            System.IO.FileInfo file = new System.IO.FileInfo(tempPath);

            if (file.Exists)
            {
                file.Delete();
            }

            MessageBox.Show("更新完了");
        }
    }
}