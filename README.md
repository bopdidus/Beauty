# BeautyMessageBox
BeautyMessageBox works exactly like default MessageBox of .NET 

## Enum BeautyMessageType
- Error: <br/>
![alt text](https://github.com/bopdidus/Beauty/blob/94be0c4731d8eb439b166b8f131750c9889241a7/error.png)
- Warning : <br/>
![alt text](https://github.com/bopdidus/Beauty/blob/94be0c4731d8eb439b166b8f131750c9889241a7/warning_color.png)
- Primary: <br/>
![alt text](https://github.com/bopdidus/Beauty/blob/c4b01e8c1ca32666fd2038eb4f7b746e446b6928/primary.png)
- Secondary : <br/>
![alt text](https://github.com/bopdidus/Beauty/blob/94be0c4731d8eb439b166b8f131750c9889241a7/secondary.png)
- Success : <br/>
![alt text](https://github.com/bopdidus/Beauty/blob/94be0c4731d8eb439b166b8f131750c9889241a7/success.png)

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

![alt text](https://github.com/bopdidus/Beauty/blob/94be0c4731d8eb439b166b8f131750c9889241a7/warning.png)

![alt text](https://github.com/bopdidus/Beauty/blob/94be0c4731d8eb439b166b8f131750c9889241a7/primary_question.png)
