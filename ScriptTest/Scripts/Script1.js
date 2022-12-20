//Dim x
//Dim y
//dim word, doc, objSelection

app.AddLog(app.MainForm.Text);
app.MainForm.Text = "Hello " + env.UserName + " from JS!";

let x = 1;
let y = 2;
app.AddLog(x + y);
app.MainForm.WindowState = clr.System.Windows.Forms.FormWindowState.Maximized;

const word = host.newComObj("Word.Application");
word.Visible = true;
const doc = word.Documents.Add();

const objSelection = word.Selection;
objSelection.Font.Name = "Arial";
objSelection.Font.Size = 18;
objSelection.TypeText(app.MainForm.Text);
objSelection.TypeParagraph();

objSelection.Font.Size = 14;
objSelection.TypeText(new Date());
objSelection.TypeParagraph();

doc.Saved = true;
//set word = Nothing