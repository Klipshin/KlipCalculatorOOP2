using System;
using System.Data; // For evaluating expressions
using System.Windows.Forms;


namespace CALC1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Result.Text = "0"; // Initialize display with 0
        }

        private bool isResultDisplayed = false; // Tracks if a result was just displayed
        private bool isOperationPerformed = false; // Tracks if an operation is currently in progress

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Reset text if "Error" is displayed
            if (textBox_Result.Text == "Error")
            {
                textBox_Result.Text = "";
                textBox_Result.ForeColor = System.Drawing.Color.Black; // Reset color
            }

            // If the result is displayed and a number is clicked, start fresh
            if (isResultDisplayed && !isOperationPerformed)
            {
                textBox_Result.Text = "";
                isResultDisplayed = false;
            }

            // If the current text is "0", replace it unless it's a dot or a negative sign
            if (textBox_Result.Text == "0" && button.Text != "." && button.Text != "-")
                textBox_Result.Text = "";

            // Prevent multiple dots in the current number
            if (button.Text == ".")
            {
                // Check if the last operator is not a dot and the last number does not contain a dot
                if (textBox_Result.Text.Length > 0 && !"+-*/".Contains(textBox_Result.Text[^1]) && !textBox_Result.Text.Split(new char[] { '+', '-', '*', '/' }).Last().Contains("."))
                    textBox_Result.Text += button.Text;
                return;
            }

            // Append the clicked button text to the result
            textBox_Result.Text += button.Text;
            isOperationPerformed = false; // Reset operation flag for numbers
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            textBox_Result.ForeColor = System.Drawing.Color.Black; // Reset color
            isOperationPerformed = false;
            isResultDisplayed = false;
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "Error")
            {
                textBox_Result.Text = "0";
                textBox_Result.ForeColor = System.Drawing.Color.Black; // Reset color
                return;
            }

            if (textBox_Result.Text.Length > 1)
            {
                textBox_Result.Text = textBox_Result.Text.Substring(0, textBox_Result.Text.Length - 1);
            }
            else
            {
                textBox_Result.Text = "0";
            }

            isOperationPerformed = false;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Reset text if "Syntax error" is displayed
            if (textBox_Result.Text == "Error")
            {
                textBox_Result.Text = "0";
                textBox_Result.ForeColor = System.Drawing.Color.Black; // Reset color
            }

            // Handle operator after displaying a result
            if (isResultDisplayed)
            {
                isResultDisplayed = false;
            }

            // If the text is "0" or empty, replace it directly with the operator
            if (textBox_Result.Text == "0" || string.IsNullOrEmpty(textBox_Result.Text))
            {
                // Allow negative sign
                textBox_Result.Text = button.Text == "-" ? "-" : "0" + button.Text; // Allow negative sign
                isOperationPerformed = true; // Set operation performed to true
                return;
            }

            // If the last character is an operator
            if ("+-*/".Contains(textBox_Result.Text[^1]))
            {
                // If the operator is a negative sign, treat it as a negative number
                if (button.Text == "-")
                {
                    // Replace the last operator with a negative sign
                    textBox_Result.Text = textBox_Result.Text.Substring(0, textBox_Result.Text.Length - 1) + button.Text;
                }
                else
                {
                    // Otherwise, just append the new operator
                    textBox_Result.Text += button.Text;
                }
            }
            else
            {
                // Append the operator only if the last character is not an operator
                if (!"+-*/".Contains(textBox_Result.Text[^1]))
                {
                    textBox_Result.Text += button.Text;
                    isOperationPerformed = true; // Set operation performed to true
                }
            }
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBox_Result.Text;

                // Validate the expression for leading zeros
                if (HasLeadingZeros(expression))
                {
                    textBox_Result.Text = "Error";
                    textBox_Result.ForeColor = System.Drawing.Color.Red; // Highlight error with red color
                    isOperationPerformed = false;
                    isResultDisplayed = true; // Mark result as displayed to reset on the next input
                    return;
                }

                // Use DataTable to evaluate the expression
                var result = new DataTable().Compute(expression, null);

                // Convert the result to a double
                double numericResult = Convert.ToDouble(result);

                // Format the result to remove unnecessary decimal places
                if (numericResult % 1 == 0)
                {
                    textBox_Result.Text = ((int)numericResult).ToString(); // Convert to int to remove decimal
                }
                else
                {
                    textBox_Result.Text = numericResult.ToString("0.##"); // Display with up to 2 decimal places
                }

                textBox_Result.ForeColor = System.Drawing.Color.Black; // Reset color
                isOperationPerformed = false;
                isResultDisplayed = true; // Set the flag to true
            }
            catch (OverflowException)
            {
                // Handle overflow exception specifically
                textBox_Result.Text = "Error";
                textBox_Result.ForeColor = System.Drawing.Color.Red; // Highlight error with red color
                isOperationPerformed = false;
                isResultDisplayed = true; // Mark result as displayed to reset on the next input
            }
            catch (Exception)
            {
                // Display "Syntax error" in the TextBox for invalid input
                textBox_Result.Text = "Error";
                textBox_Result.ForeColor = System.Drawing.Color.Red; // Highlight error with red color
                isOperationPerformed = false;
                isResultDisplayed = true; // Mark result as displayed to reset on the next input
            }
        }

        // Method to check for leading zeros in the expression
        private bool HasLeadingZeros(string expression)
        {
            // Split the expression into parts based on operators
            string[] parts = expression.Split(new char[] { '+', '-', '*', '/' });

            foreach (string part in parts)
            {
                // Trim whitespace and check if the part is a number
                string trimmedPart = part.Trim();
                if (trimmedPart.Length > 1 && trimmedPart.StartsWith("0") && !trimmedPart.Equals("0"))
                {
                    return true; // Found a number with leading zeros
                }
            }

            return false; // No leading zeros found
        }

        private void button_neg_Click(object sender, EventArgs e)
        {
            // Check if the textbox is not empty and not equal to "0"
            if (!string.IsNullOrEmpty(textBox_Result.Text) && textBox_Result.Text != "0")
            {
                string text = textBox_Result.Text;
                int lastNumberStart = -1;

                // Find the start index of the last number in the expression
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    if (char.IsDigit(text[i]) || text[i] == '.' || text[i] == '-')
                    {
                        lastNumberStart = i;

                        // Move backwards to find the start of the number
                        while (lastNumberStart > 0 && (char.IsDigit(text[lastNumberStart - 1]) || text[lastNumberStart - 1] == '.' || text[lastNumberStart - 1] == '-'))
                            lastNumberStart--;
                        break;
                    }
                }

                // If a valid number start index was found
                if (lastNumberStart != -1)
                {
                    string beforeNumber = text.Substring(0, lastNumberStart); // Part before the last number
                    string numberPart = text.Substring(lastNumberStart); // The last number part

                    // Toggle the sign of the last number
                    if (numberPart.StartsWith("-"))
                    {
                        numberPart = numberPart.Substring(1); // Remove the negative sign
                    }
                    else
                    {
                        numberPart = "-" + numberPart; // Add a negative sign
                    }

                    // Update the textbox with the new expression
                    textBox_Result.Text = beforeNumber + numberPart;
                }
            }
        }
    }
}
