using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Superhero_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {   
            InitializeComponent();
        }
        // tuple fuction is a function that uses the C# tuple syntax in its return type
        // it is used when a method needs to return multiple related values to the caller
        // tuple function that calculates the rank and threal level automatically based on the exam score entered by the user
        private (string rank,string threat) CalculatedRankAndThreat(int score)
        {
            if (score >= 81)
                return ("S-Rank", "Finals Week (threat to the entire academy)");
            else if (score >= 61)
                return ("A-Rank", "Midterm Madness (threat to a department)");
            else if (score >= 41)
                return ("B-Rank", "Group Project Gone Wrong (threat to a study group)");
            else
                return ("C-Rank","Pop Quiz (potential threat to an individual student)");
        }
        // function that lads the heros into the grid
        private void LoadHeroesIntoGrid()
        {
            // clearing the rows of the Data Grid View
            Heroesdgv.Rows.Clear();
            // the location of the file
            string filePath = "superheroes.txt";
            // stops the program if the file does not exist
            if (!File.Exists(filePath)) return;

            // reads everyline from the superheroes text file and stores that as an array of sstrings
            string[] lines = File.ReadAllLines(filePath);
            // loop that adds each complete record as a new row in the Data Grid View
            foreach (var line in lines)
            {
                // splits the data into an array of individual strings
                var data = line.Split(',');
                // validation to ensure that the data array has exactly 8 elements
                if (data.Length == 8)
                // adds data to the Grid
                Heroesdgv.Rows.Add(data);
            }
        }
        // function that adds a new superhero to the Grid
        private void Addbtn_Click(object sender, EventArgs e)
        {
            // input validation of number entered as the score 
            if (!int.TryParse(ExamScoretxt.Text, out int score))
            {
                MessageBox.Show("Enter a valid number for the score");
                return;
            }
            // input validation of number entered as the age
            if (!int.TryParse(Agetxt.Text, out int ageValue))
            {
                MessageBox.Show("Enter a valid number for the Age.");
                return;
            }
            // the calculation of the Rank and Threat
            // keyword var is C#s modern way of as it tells the C# compiler to automatically determine the type of the variables being declared based on the parameter of the function
            // this syntax is called tuple deconstruction  as it immeadiatley unpacks the 2 return values from the function into 2 separate usable variable
            var ( rank, threat) = CalculatedRankAndThreat(score);
            Rankcmb.Text = rank;
            ThreatLevelcmb.Text = threat;

            // creating a hero object from the class Superhero
            Superhero hero = new Superhero()
            {
                // the .Trim removes leading and trailing whitespace characters from the strings retrived from the text boxes
                SuperheroID = SuperheroIDtxt.Text.Trim(),
                Name = Nametxt.Text.Trim(),
                Age = ageValue,
                Superpower = SuperPowertxt.Text.Trim(),
                City = Citytxt.Text.Trim(),
                ExamScore = score,
                Rank = rank,
                ThreatLevel = threat,
            };

            // saving to the file 

            // creating a file
            string filePath = "superheroes.txt";
            // declaring the variable heroLine and assigning it the values of the information of the differnt superheroes
            string heroLine = $"{hero.SuperheroID},{hero.Name},{hero.Age},{hero.Superpower},{hero.City},{hero.ExamScore},{hero.Rank},{hero.ThreatLevel}";
            // method that opens a file and appends a collection of strings to the end of the file and then closes the file automatically
            // it is saving the single superhero record to the text file created
            File.AppendAllLines(filePath,new[] { heroLine });

            // confirming and clearing the fields
            // method that shows the user a confirmation message after the superhero data has been saved
            /*
             MessageBox.Show is the core method that opens a small window to interact with the user
             SuperHero added successfully! is the string displayed to the user
             Success is the title that appears in the title bar of the dialog window
             MessageBoxButtons.OK specifies that the OK button should appear on the dialog box
             MessageBoxIcon.Information specifies the icon to be displayed in the dialog box
            */
            MessageBox.Show("SuperHero added successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

            // clearing the fields of the form 
            SuperheroIDtxt.Clear();
            Nametxt.Clear();
            Agetxt.Clear();
            SuperPowertxt.Clear();
            Citytxt.Clear();
            ExamScoretxt.Clear();
            Rankcmb.Text = "";
            ThreatLevelcmb.Text = "";
            // loading the superheroes to the grid
            LoadHeroesIntoGrid();

        }
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            
        {
            try
            {
                string filePath = "superheroes.txt";

                // Check if file exists
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("No data file found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure all fields are filled
                if (string.IsNullOrWhiteSpace(SuperheroIDtxt.Text) ||
                    string.IsNullOrWhiteSpace(Nametxt.Text) ||
                    string.IsNullOrWhiteSpace(SuperPowertxt.Text) ||
                    string.IsNullOrWhiteSpace(Citytxt.Text) ||
                    string.IsNullOrWhiteSpace(Agetxt.Text) ||
                    string.IsNullOrWhiteSpace(ExamScoretxt.Text))
                {
                    MessageBox.Show("Please fill in all fields before updating.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Load all heroes from the file
                var heroes = File.ReadAllLines(filePath).ToList();
                string idToUpdate = SuperheroIDtxt.Text.Trim();
                bool found = false;

                // Loop through each hero record
                for (int i = 0; i < heroes.Count; i++)
                {
                    var data = heroes[i].Split(',');

                    if (data[0].Trim() == idToUpdate)
                    {
                        // Confirm update before making changes
                        DialogResult confirm = MessageBox.Show(
                            "Are you sure you want to update this superhero?",
                            "Confirm Update",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (confirm != DialogResult.Yes)
                            return;

                        // Validate Age and Score
                        if (!int.TryParse(Agetxt.Text, out int ageValue))
                        {
                            MessageBox.Show("Enter a valid number for the Age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (!int.TryParse(ExamScoretxt.Text, out int score))
                        {
                            MessageBox.Show("Enter a valid number for the Score.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Recalculate rank and threat level
                        var (rank, threat) = CalculatedRankAndThreat(score);

                        // Update the hero's data line
                        string updatedHeroLine = $"{idToUpdate},{Nametxt.Text.Trim()},{ageValue},{SuperPowertxt.Text.Trim()}," +
                                                 $"{Citytxt.Text.Trim()},{score},{rank},{threat}";

                        // Replace the old line with the updated one
                        heroes[i] = updatedHeroLine;
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    // Save updated data back to file
                    File.WriteAllLines(filePath, heroes);

                    MessageBox.Show("Superhero updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh DataGridView
                    LoadHeroesIntoGrid();
                }
                else
                {
                    MessageBox.Show("Superhero ID not found. Please check the ID again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating hero: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        { // function checking if the user has not selected a row
            if (Heroesdgv.SelectedRows.Count == 0)
            {
                /*
            MessageBox.Show is the core method that opens a small window to interact with the user
            Please select a hero to delete. is the string displayed to the user
            No Selection is the title that appears in the title bar of the dialog window
            MessageBoxButtons.OK specifies that the OK button should appear on the dialog box
            MessageBoxIcon.Warning specifies the warning icon to be displayed in the dialog box
           */
                MessageBox.Show("Please select a hero to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // retrieving the superheroID and accessing the first row in the collection of rows and accesses the specific row that was selected by the user then converts the object into a string
            string SuperheroID = Heroesdgv.SelectedRows[0].Cells["SuperheroID"].Value.ToString();
            /*
          MessageBox.Show is the core method that opens a small window to interact with the user
         Are you sure you want to delete Superhero ID is the string displayed to the user
          Confirm Delete is the title that appears in the title bar of the dialog window
          MessageBoxButtons.YesNo specifies that the Yes and No button should appear on the dialog box
          MessageBoxIcon.Question specifies the question icon to be displayed in the dialog box
         */
            // asking the user for confirmation before deleting a record
            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Superhero ID {SuperheroID}?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
                return;

            string filePath = "superheroes.txt";
            if (!File.Exists(filePath))
            {
                /*
          MessageBox.Show is the core method that opens a small window to interact with the user
          No data file found.is the string displayed to the user
          Error is the title that appears in the title bar of the dialog window
          MessageBoxButtons.OK specifies that the OK button should appear on the dialog box
          MessageBoxIcon.Error specifies the error icon to be displayed in the dialog box
         */
                // what displays if the file does not exist
                MessageBox.Show("No data file found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // reads all the text lines from the file and converts them into a collection of strings
            var heroes = File.ReadAllLines(filePath).ToList();
            // filters the list of all hero records and creates a new list that excludes the hero that was selected to be deleted
            var updatedHeroes = heroes.Where(line => !line.StartsWith(SuperheroID + ",")).ToList();

            // Saving updated list
            File.WriteAllLines(filePath, updatedHeroes);

            /*
           MessageBox.Show is the core method that opens a small window to interact with the user
           SuperHero deleted successfully! is the string displayed to the user
           Success is the title that appears in the title bar of the dialog window
           MessageBoxButtons.OK specifies that the OK button should appear on the dialog box
           MessageBoxIcon.Information specifies the icon to be displayed in the dialog box
          */
            MessageBox.Show("Hero deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refreshing the grid
            LoadHeroesIntoGrid();
        }

        private void ViewAllbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Load all heroes from the file
                LoadHeroesIntoGrid();

                // Confirmation message
                MessageBox.Show("All superheroes loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading heroes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Summarybtn_Click(object sender, EventArgs e)
        {
      
        {
            try
            {
                string filePath = "superheroes.txt";
                string summaryPath = "summary.txt";

                // Check if the superhero data file exists
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("No superhero data file found.", "File Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Read all hero data
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length == 0)
                {
                    MessageBox.Show("The data file is empty. Please add superheroes first.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int totalHeroes = 0;
                int totalAge = 0;
                int totalScore = 0;
                int sCount = 0, aCount = 0, bCount = 0, cCount = 0;

                // Process each hero record
                foreach (var line in lines)
                {
                    var data = line.Split(',');

                    // Skip invalid or incomplete lines
                    if (data.Length < 8)
                        continue;

                    totalHeroes++;

                    if (int.TryParse(data[2], out int age))
                        totalAge += age;

                    if (int.TryParse(data[5], out int score))
                        totalScore += score;

                    string rank = data[6].Trim();
                    switch (rank)
                    {
                        case "S-Rank": sCount++; break;
                        case "A-Rank": aCount++; break;
                        case "B-Rank": bCount++; break;
                        case "C-Rank": cCount++; break;
                    }
                }

                // Calculate averages safely
                double avgAge = totalHeroes > 0 ? (double)totalAge / totalHeroes : 0;
                double avgScore = totalHeroes > 0 ? (double)totalScore / totalHeroes : 0;

                // Display results on the form (use TextBoxes or Labels with these names)
                TotalHeroestxt.Text = totalHeroes.ToString();
                Agetxt.Text = avgAge.ToString("F2");
                ExamScoretxt.Text = avgScore.ToString("F2");
                SRanktxt.Text = sCount.ToString();
                ARanktxt.Text = aCount.ToString();
                BRanktxt.Text = bCount.ToString();
                CRanktxt.Text = cCount.ToString();

                // Build report content
                string summaryReport =
                    "===== Superhero Summary Report =====\n" +
                    $"Total Heroes: {totalHeroes}\n" +
                    $"Average Age: {avgAge:F2}\n" +
                    $"Average Exam Score: {avgScore:F2}\n\n" +
                    $"S-Rank Heroes: {sCount}\n" +
                    $"A-Rank Heroes: {aCount}\n" +
                    $"B-Rank Heroes: {bCount}\n" +
                    $"C-Rank Heroes: {cCount}\n" +
                    "=====================================\n" +
                    $"Report generated on: {DateTime.Now}\n";

                // Confirm before saving
                DialogResult confirm = MessageBox.Show(
                    "Generate and save the summary report to summary.txt?",
                    "Confirm Report Generation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                    return;

                // Save report to file
                File.WriteAllText(summaryPath, summaryReport);

                MessageBox.Show("Summary report generated and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating summary report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        }

        

        
    }
}
