# BeautyMessageBox
BeautyMessageBox works exactly like default MessageBox of .NET 

## Enum BeautyMessageType
- Error: <br/>
![alt text](https://github.com/bopdidus/Beauty/blob/master/error.png)
- Warning : <br/>
![alt text](https://github.com/bopdidus/Beauty/blob/master/warning_color.png)
- Primary: <br/>
![alt text](https://github.com/bopdidus/Beauty/blob/master/primary.png)
- Secondary : <br/>
![alt text](https://github.com/bopdidus/Beauty/blob/master/secondary.png)
- Success : <br/>
![alt text](https://github.com/bopdidus/Beauty/blob/master/success.png)

## Enum BeautyMessageIcon
  - TickMark
  - Question
  - CrossMark
  - Information
  - ExclamationMark

## Enum BeautyMessageButtons
  - YesNo
  - OK
  - CancelTryContinue
  - OKCancel
## How to use it
* Constructor
  <code>
 BeautyMessageBox(string title, string message, BeautyMessageType type, BeautyMessageButtons btn, BeautyMessageIcon icon);
</code>
* Example:
<code>
var box = new BeautyMessageBox("Info", "Save done!", BeautyMessageType.Success, BeautyMessageButtons.OK, BeautyMessageIcon.TickMark);
box.ShowDialog();
</code>
## Examples

![alt text](https://github.com/bopdidus/Beauty/blob/master/warning.png)

![alt text](https://github.com/bopdidus/Beauty/blob/master/primary_question.png)
