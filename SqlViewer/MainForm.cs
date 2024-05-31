using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Zadatak.Dal;
using Zadatak.Models;
using System.Data.SqlClient;
using System.Drawing;

namespace Zadatak
{
    public partial class MainForm : Form
    {
        SqlDataAdapter da;
        DataSet ds;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }
        SqlConnection con = RepositoryFactory.GetRepository().getCon();
        private SqlRepository repo=new SqlRepository();
        private void Init() => LoadDatabases();

        private void LoadDatabases() => CbDatabases.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());

        

        private void Clear()
        {
          commandTb.Clear();
          messagesTB.Clear();
          resultsDS.DataSource = null;
          
        }

      

     


      

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void executeBtn_Click(object sender, EventArgs e)
        {
            string query = commandTb.Text.ToLower();
           
            con.Open();
           // con.ChangeDatabase(CbDatabases.SelectedItem.ToString());
           if(query.Contains("select "))
            {
                try
                {

                    SelectStatementIntoDataset(query,con);
                }
                catch (Exception ex)
                {
                    messagesTB.SelectionColor = Color.Red;
                    messagesTB.SelectedText = $"{ex.Message}" + System.Environment.NewLine;
                    messagesTB.SelectionColor = Color.Black;
                    messagesTB.SelectedText = "";
                }
               
            }
           else
            {
               
                SqlCommand com=new SqlCommand(query,con);
                try
                {
                    OtherStatementIntoTextBox(query, con);
                }

                catch (Exception ex)
                {
   
                 
                    //messagesTB.Select();
                    messagesTB.SelectionColor = Color.Red;
                    messagesTB.SelectedText = $"{ex.Message}" + System.Environment.NewLine;
                    messagesTB.SelectionColor = Color.Black;
                    messagesTB.SelectedText = "";
                    //messagesTB.SelectionColor = Color.Black;
                }
               
               
                
            }
            
            con.Close();
        }

        private void CbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            

            // LbTables.DataSource = (CbDatabases.SelectedItem as Database).Tables;
            //LbViews.DataSource = (CbDatabases.SelectedItem as Database).Views;
            //LbProcedures.DataSource = (CbDatabases.SelectedItem as Database).Procedures;
        }

        private void SelectStatementIntoDataset(string query,SqlConnection con)
        {
            string s = con.Database;
            if (s != CbDatabases.SelectedItem.ToString())
            {
                con.ChangeDatabase(CbDatabases.SelectedItem.ToString());
            }
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                resultsDS.DataSource = ds.Tables[0];
                
                messagesTB.SelectedText = $"({ds.Tables[0].Rows.Count} rows affected)" + System.Environment.NewLine;
            }
        }

        private void OtherStatementIntoTextBox(string query,SqlConnection con)
        {
            if (con.Database != CbDatabases.SelectedItem.ToString())
            {
                con.ChangeDatabase(CbDatabases.SelectedItem.ToString());
            }
            SqlCommand com = new SqlCommand(query, con);
            int i = com.ExecuteNonQuery();
            messagesTB.SelectedText = $"({i} rows affected)" + System.Environment.NewLine;

        }
    }
}
