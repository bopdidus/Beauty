# BeautyMessageBox
BeautyMessageBox works exactly like default MessageBox of .NET 

## Enum BeautyMessageType
- Error: <br/>
![error](https://github.com/bopdidus/Beauty/assets/73300943/4eb60bc3-7591-4eda-be68-4f38ba0e7a4f)
- Warning : <br/>
![warning_color](https://github.com/bopdidus/Beauty/assets/73300943/30887dda-77e1-4e88-b7a8-c8a69860fda5)
- Primary: <br/>
![primary](https://github.com/bopdidus/Beauty/assets/73300943/e1f275c8-628c-423a-b0db-efa480931c76)
- Secondary : <br/>
![secondary](https://github.com/bopdidus/Beauty/assets/73300943/d280114e-61f1-445a-adcf-69ef642405eb)
- Success : <br/>
![success](https://github.com/bopdidus/Beauty/assets/73300943/692da1e4-e15c-45b8-b755-a1b878b6ab83)

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

![warning](https://github.com/bopdidus/Beauty/assets/73300943/d9e5450d-1b6e-4796-aa37-a83976354799)

![succes_tick](https://github.com/bopdidus/Beauty/assets/73300943/2f03447b-f7d9-416e-9a71-202921384b1e)

![primary_question](https://github.com/bopdidus/Beauty/assets/73300943/1e56b4b4-0d32-4280-8a6c-24df18ceed1c)