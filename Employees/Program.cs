using System;
using System.Collections.Generic;
using System.Text;
using Spectre.Console;
using System.Threading;
//fixed  bugs

namespace Employees
{


     
     class Program
    {
        static  List<Employee> employees = new List<Employee>();
        static void Main() {
            AnsiConsole.Write(new FigletText("Employees System").Centered());
            AnsiConsole.Status().Start("Loading Employees System...", ctx =>
                        {
                            ctx.Spinner(Spinner.Known.Dots);

                // Simulate some work being done
                System.Threading.Thread.Sleep(2000);
            });


                


            ShowMain();
            var footer = new Panel(
                $"Thank you for using Employees System!{Environment.NewLine}Created by: Himanshu");
            footer.Header = new PanelHeader("Footer").Centered();
            footer.Border = BoxBorder.Rounded;
            AnsiConsole.Write(footer);
        }
        static void ShowMain()
        {
          /*  string background = @"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMWNKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKXXXXXXXXXNNNWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKXXXXXXXXXNNNWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWNXXXXXKKKKKKKXXXNNWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMNd''''''''''''''''''''''''''''''''''''''''''''''''',,,,;;:cclodxO0KNWMMMMMMMMMMMMMMMMMMMKc'''''''''''''''''''''''''''''''''''''''''''''''''''''',,,,,,;;;:cclodkOKXWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNX0kxdol:;,,,'''''''''',,;:clodkOKXNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMNl................................................................';cdk0NWMMMMMMMMMMMMMMK;.......................................................................',:ox0NWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWX0xoc;,...............................',:ldOKNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMNl......................................................................;lx0NWMMMMMMMMMMK;.............................................................................;lkXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN0ko:,...........................................';cdOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMNl.........................................................................':d0NMMMMMMMMK;................................................................................,oONMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKko:'....................................................,cd0NWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMNl............................................................................':xKWMMMMMK:...................................................................................ckNMMMMMMMMMMMMMMMMMMMMMMMMWKxc,............................................................;oOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMNl...............................................................................,oKWMMMNd'....................................................................................cOWMMMMMMMMMMMMMMMMMMMWKkc'..................................................................;o0NMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMNl.................................................................................,oKWMMW0l'...................................................................................'dXMMMMMMMMMMMMMMMMN0o,.......................................................................':xXWMMMMMMMMMMMMMMMMMMMMMMM
MMMMNl...................................................................................,xXWMMNO:....................................................................................cKWMMMMMMMMMMMMNkc'............................................................................;dKWMMMMMMMMMMMMMMMMMMMMM
MMMMNl.....................................................................................:OWMMMXd,...................................................................................:0WMMMMMMMMMNk:.................................................................................,o0WMMMMMMMMMMMMMMMMMMM
MMMMNl.......................,;;;;;;;;;;;;;;;;;,,,,,''......................................,xNMMMWO:...............':lllllllllllllcccccccccccccc::::;;,,'..............................cKMMMMMMMNk:....................................',;;:::::;;,,'...................................,oKWMMMMMMMMMMMMMMMMM
MMMMNl......................,kNNNNNNNNNNNNNNNNNNXXXXKK00Okxdlc;...............................lKMMMWKl..............:KWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNXK0koc'..........................oNMMMMMNo..............................';codkO0KXNNWWWWWNNNXK0Oxol:,..............................;xXMMMMMMMMMMMMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWX0ko;............................cKWMMMXo.............:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNKx;........................,OMMMMMNo..........................,cokKNWMMMMMMMMMMMMMMMMMMMMMMMWNXOxl;'...........................c0WMMMMMMMMMMMMMM
MMMMNl......................,0MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNOo,..........................c0WMMMNd'...........:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXo'.......................dNMMMMWO,......................;oOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWN0xc,.........................,dXMMMMMMMMMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd;.........................cKMMMMNo...........:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNd'......................lXMMMMMK:...................;o0NWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKxc'........................lKWMMMMMMMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKl'........................lXMMMMXl..........:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXc......................cXMMMMMKc.................ckXWMMMMMMMMMWNXNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN0o,.......................:0WMMMMMMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNx,.......................'dNMMMM0:.........:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWd......................lXMMMMMKc..............'cONMMMMMMMMMMWKOxodkKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd;......................;OWMMMMMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk,.......................;OWMMMWk'........:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWx'.....................oNMMMMM0;.............:ONMMMMMMMMMWN0xolllllokKNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKo,.....................;OWMMMMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk,.......................lXMMMMXl........:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNo.....................,kWMMMMWx'...........,xNMMMMMMMMMWXOdlllllllllloxKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMW0c.....................;OWMMMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNo.......................,kWMMMWO,.......:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM0:.....................cXMMMMMKc...........c0WMMMMMMMMWXkollllllllllllllokXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXd,....................:0MMMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK:.......................lXMMMMXl.......:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKl.....................;OWMMMMNd...........oXWMMMMMMMWXkolllllllllllllllllldONWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk;....................lXMMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWx'......................;0MMMMWx'......:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNk:.....................,xWMMMMNx,.........'dNMMMMMMMMN0dllllllllllllllllllllllx0NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWO;...................'xWMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM0;.......................dWMMMM0:......:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNKxc'.....................,kNMMMMNx'..........oNMMMMMMMWXkolllllllllllloollllllllllokXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWO;...................;0MMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXl.......................lXMMMMNl......:0WWWWWWWWWWWWWWWWWWWWWWWWWWNNNNNXKK0Oxo:'.......................:OWMMMMXo'..........lXMMMMMMMWKdllllllllllllldkdlllllllllllld0NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk,...................dNMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWx.......................;KMMMMWd.......;ccccccccccccccccccccc::::::;;;;,''...........................'oXMMMMNO:...........;0MMMMMMMW0dllllllllllllllx0xlllllllllllllokNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNd...................;0MMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk'......................,OMMMMWk'..................................................................'l0WMMMN0l'...........'dWMMMMMMWKdlllllllllllllloOXklllllllllllllllkXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK:..................'xWMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM0;......................'xWMMMM0;................................................................;d0WMMWXkc'.............:KMMMMMMWKdllllllllllllllldKNOolllllllllllllllxXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNd...................lXMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK:.......................dWMMMMK:............................................................':oOXWMWXkl,................oNMMMMMMXkllllllllllllllllxXW0ollllllllllllllod0WMMMMMMMMMMMMMMMMMMMMMMMMMMMMMO,..................:KMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK:.......................dNMMMMK:............................................................ckKNWMMWk:'................'kWMMMMMW0ollllllllllllllllONW0ollllllllloxk0KXNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXc..................;0MMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK:.......................oNMMMMXc..............................................................':lxKNWX0ko:'............,OMMMMMMNkllllllllllllllllo0WMKdlllllloxOXNMMMMWWNNXXKKKKKKKKKXXXNNWMMMMMMMMMMMNl..................,0MMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK:.......................oNMMMMXc..................................................................':oONMMNKxl,.........;0MMMMMMNxlllllllllllllllldKMMXxllllox0NWMMWNK0kxddooolllllllloooodONMMMMMMMMMMNo..................,OMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK:.......................oNMMMMXc......................................................................:xKWMMWKx:.......,OMMMMMMNkllllllllllllllllxXMMNkllldONMMMWKOdollllllllllllllllllllldXMMMMMMMMMMNl..................,OMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK:.......................oNMMMMKc........................................................................,dKWMMWNk:.....'kWMMMMMW0olllllllllllllllkNMMNOlld0WMMWXkolllllllllllllllllllllllldKMMMMMMMMMMXc..................;0MMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM0;.......................dWMMMMK:......'''''''''''''''''''''''''''.........................................;xXMMMMXx;....dNMMMMMMXxlllllllllllllloOWMMWOoo0WMMWKxllllllllllllllllllllllllllo0WMMMMMMMMM0;..................:KMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMO,.......................xWMMMM0;.....;kKKKKKKKKKKKKKKKKKKKKKKKKKK000OOkkkxddoc:,............................lKWMMMW0c...cKMMMMMMWOolllllllllllllo0WMMW0dONMMWXxllllllllllllllllllllllllllloOWMMMMMMMMWx'..................lXMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk'......................,kWMMMWO,.....:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNX0xc,.........................:OWMMMMXo..'kWMMMMMMNkllllllllllllldKMMMMKOXMMMNkollllllllllllllloolllllllllloOWMMMMMMMMKc...................dWMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNd.......................;0MMMMWx'.....:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKd;........................:0WMMMMXo..cKMMMMMMMXxlllllllllllldKMMMMNXWMMWKdlllllllllllllldxxolllllllllloOWMMMMMMMWx'..................,OMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXl.......................cXMMMMNo......:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKo........................cKMMMMMKc..dNMMMMMMWXxlllllllllllxXMMMMMMMMMWOollllllllllloxO0xollllllllllloOWMMMMMMW0;...................lXMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM0;.......................dNMMMMK:......:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNd'.......................dNMMMMWO,.,kWMMMMMMWXxllllllllllxNMMMMMMMMMNklllllllllldkKX0dllllllllllllldKMMMMMMMKc...................,OWMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWd.......................;0MMMMWx'......:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXl.......................:KMMMMMXl..,kWMMMMMMMNOollllllllkNMMMMMMMMMXxllllllloxOXNXkollllllllllllllONMMMMMMKc....................oNMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK:.......................lXMMMMXl.......:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWO,......................'kWMMMMWx'..,xNMMMMMMMWKxollllllkNMMMMMMMMMKdlllllokKNWN0dlllllllllllllllxXMMMMMMKc....................:KMMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNd.......................,OMMMMWk,.......:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK:.......................xWMMMMWO,...'dXMMMMMMMMN0xollloOWMMMMMMMMMKdllodOXWMWXxolllllllllllllloxXWMMMMWO:....................,OWMMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk,.......................oNMMMMKc........:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK:.......................oNMMMMM0;.....c0WMMMMMMMMNKkdooOWMMMMMMMMMKdox0NWMMNOdllllllllllllllldONMMMMWXd,....................'xNMMMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMW0;.......................:0MMMMNd.........:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMO,.......................dWMMMMM0;......,dXWMMMMMMMMWNK0XWMMMMMMMMMX0KWMMMWKxolllllllllllllldOXWMMMMNO:.....................'xNMMMMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMW0:.......................,kWMMMWk,.........:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNo.......................'xWMMMMWk,........;xXWMMMMMMMMMMMMMMMMMMMMMMWMMMMNOdllllllllllllodk0NWMMMMN0l'.....................'dNMMMMMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNk;.......................'xNMMMW0:..........:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk,.......................;0MMMMMNo...........;dKWMMMMMMMMMMMMMMMMMMMMMMMWXkdoooooodddxkO0XNWMMMMWNOc'......................,xNMMMMMMMMMM
MMMMNl......................,0MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNOc.........................oNMMMMKc...........:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNx,........................lXMMMMMK:.............,lOXWMMMMMMMMMMMMMMMMMMMMWNXXXXXXXXNNWWMMMMMMMMWKd:........................;OWMMMMMMMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNKx:'.........................oXMMMWKc............:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXk:.........................,OWMMMMNd.................;okXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWN0xc'.........................c0WMMMMMMMMMMMM
MMMMNl......................,OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNX0ko:'..........................'dNMMMW0c.............:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNKko;...........................oNMMMMWO;....................,cdOXNWMMMMMMMMMMMMMMMMMMMMMMMMMMWX0xl;...........................,xNMMMMMMMMMMMMMM
MMMMNl......................'dO00000000000000000OOOOOkkkxddlc:,..............................,xNMMMWO:..............,x000000000000000000000000OOOOOOOkkkkxddoc;'.............................lXMMMMWK:.........................,:ldk0KXNWWMMMMMMMMMWWWNXKOxoc;'.............................l0WMMMMMMMMMMMMMMM
MMMMNl......................................................................................:0WMMMNd,.......................................................................................cKMMMMMXl................................',:clloodddooolc:;,'.................................:ONMMMMMMMMMMMMMMMMM
MMMMNl....................................................................................'oXMMMW0c........................................................................................lKMMMMMMKo'..................................................................................;xXMMMMMMMMMMMMMMMMMMM
MMMMNl...................................................................................c0WMMWKo,.......................................................................................'oXMMMMMMMMW0o,..............................................................................:kXWMMMMMMMMMMMMMMMMMMMM
MMMMNl.................................................................................:kNMMWXx;........................................................................................:OWMMMMMMMMMMMWKd;.........................................................................'lONMMMMMMMMMMMMMMMMMMMMMMM
MMMMNl..............................................................................'lONMMMMXl........................................................................................;xXMMMMMMMMMMMMMMMWXOl,....................................................................:xKWMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMNl...........................................................................':d0WMMMMMMK;......................................................................................:xKWMMMMMMMMMMMMMMMMMMMWKkl,.............................................................':dONWMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMNl........................................................................,cx0NMMMMMMMMMK:...................................................................................;lONWMMMMMMMMMMMMMMMMMMMMMMMMWXko;'......................................................,cd0NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMNl...................................................................';lx0XWMMMMMMMMMMMMK;...............................................................................,cdOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWN0xl;'..............................................,cdOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMNl............................................................',;coxOKNWMMMMMMMMMMMMMMMMK;........................................................................',:cox0XWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNKOdl;'...................................';cox0XWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMWkc::::::::::::::::::::::::::::::::::::::::::::cccccclooddxkO0KXNWMMMMMMMMMMMMMMMMMMMMMMXd::::::::::::::::::::::::::::::::::::::::::ccccccccccccllllllooooddddxkO0KXNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNX0kxoc:;,'.................'',;cldxOKXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNNXK0OkkkxxxddxxxkkO0KXXNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMNXKKKKKKXNWMMMMMW0xdkXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXKKKKKKXNWMMMMNOk0WMMMMMMMMMMMMMMMMMMMMMMMMMWNXK00KXNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKOOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMNKKKNMMMMMMMMMMMMMMMMMMMMMMMWKkdxKWMMMMMMMMM
MMMMWx:;;:::::coxKWMMNx;,:0MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM0c;;:::::cd0NMWk:,lKMMMMMMMMMMMMMMMMMMMMMMMN0dc:;;;;:lxKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXo,;dXMMMMMMMMMMMMMMMMMMMMMMMMMMMWOc;cOWMMMMMMMNK00NMMMMMMMMMMWO:,;kWMMMMMMMMM
MMMMNd,,:dOOkdc,,:dXMNx;,:0WWNNWMMMMMMWWNNNWWMMMMWWWWMWWNNWMMMWNNWWMMMMWWWWMWNNNWMMMMMWWWWMMMWWWWWMMWWWWMWNWMMMMMWO:,;oO0kl,,:OWMXOk0NMMMMMWNNNWWMMMMMMMMMMWXd;,;okOOxc,,:kNMMWWWWWWNWMMMMWNNWWWWWWMMMWWWNNNWWMMMMWWWWMWWNNWMMMMWKkkKWMMMMMWNNNNWMMMWWNNNWWMMMMMMWk;,;kWMMMMMWXx:;c0WWMMMMWNNNNO:,;kWMMMMMMMMM
MMMMNd,,cKMMMWXd;,;dXNx;,:ddlcloONMMNOolcccldONMMKdldkdlccoO0kocclxXWMXxlokkolcldONMMKdloOWMW0old0WNklokkolkNMMMMWO:,;xNWXd;,cOWWOoldKMMW0xoccclokXWMMMMMMMXo,,:kNMMMWKo,,:kWNxloOkolkNW0xlcclxxolkNMXkolccclx0WMW0oldkdlccokXMMXxlokNMMN0xolcclkNW0xlccco0WMMMMMWk;,;kWMMMMWKo;,,;clkNWXkolclol;,;kWMMMMMMMMM
MMMMNd,,c0MMMMMKc,,c0Nx;,,:ooc,,;xNMNOdxkko;,:xNM0:,,:loc;,,;coo;,,oXMKl,,;codl;,;oXW0:,;xNMWk;,:OWXo,,;:clkNMMMMWO:,,:ll:;;l0WMNx;,:0MXx;,;oxxc,,cOWMMMMMM0:,,oXMMMMMWO:,,oNXl,,;:clOXx:,;lddc;,,oXMXkdxkxl;,cOWWk;,,:lol;,;dXMKl,,oXWKo;,;ldxx0NO:,;okxxKWMMMMMWk;,;kWMMMMMKd:,,;ox0NOc,,:dxo:,,;kWMMMMMMMMM
MMMMNd,,c0MMMMMKl,,cKNx;,:kWWKl,,lXMWXOxdol;,,lXM0:,,dXWKl,,c0WNx;,:OWXl,,c0WMNx;,;kN0:,;xNMWk;,:OWXo,,:xXNWMMMMMWO:,;cddo:;:o0WNx;,:0Wk;,;xNMW0c,,lKMMMMMWO:,,oXMMMMMWO:,,oXXl,,:kXNWO:,;dXMWOc,,oNMWKOxdol;,,dNWk;,;dXWXo,,c0MKl,,oXXo,,:kNMMMMWO:,;lxOXWMMMMMMWk;,;kWMMMMMMXd,,cKMMXl,,c0WMNx;,;kWMMMMMMMMM
MMMMNd,,c0MMMMNx;,;dNNx;,:0MMXo,,lKWOc,;lxdc,,lKM0c,;xNMXo,,lXMWk:,:OWXl,,lKMMWO:,;xN0:,;xNMWk;,:OWXo,,lKMMMMMMMMMO:,;kWMWOc,,lKNx;,:0Nx;,;kWMMXl,,cKMMMMMMKl,,:OWMMMMXd;,;kWXl,,lXMMWk;,;xNMMKc,,oNNk:,;oxd:,,oXWk;,;kWMNx;,:0MKl,,oXKl,,cKMMMMMMW0xl:,,:xXMMMMMWk;,;kWMMMMMMNd,,cKMMKl,,lXMMWk:,;kWMWWWWMMMM
MMMMNd,,:kKKOxl;,:dXMNx;,:0MMXo,,lKXo,,cOXOc,,lKM0:,;xNMXo,,lXMWk:,:OWXl,,:xKKOl,,c0WKc,,ckKkl,,:OWXo,,lKMMMMMMMMWO:,;xKX0d:,,oXNx;,:0W0c,,lOXXx:,;xNMMMMMMW0l,,:x0K0kl;,;xNMXl,,lXMMMKl,,cx0Oo;,,oXKc,,l0Xk:,,oXWk;,;kWMNx;,:0MKl,,oXNx;,;lOKKKNWXKXKOl,,c0MMMMMWk;,;oOOOOOKNNx;,:xKNNx;,;d0KOl,,;kWNkllkNMMM
MMMMNd,,,;:;;;:lx0NMMNx;,c0MMXo;,lKNOc;;:ccc;,lKM0c,;xWMXd;,lXMWk:,:OWXl,,;:::;;:o0WMWOc;,;:cl:,:kWXo;,lKMMMMMMMMWO:,,;:::;:lxXWNx;,c0MW0o:;;c:;:lkNMMMMMMMMWXxl;;;;;;;co0NMMXo,,oXMMMWKdc;;:cl;,,dNNx:,;ccc:;;oXWk:,:kWMNx;,c0MKl,;oXMNkl;,;;::xXxc:cc;;ckNMMMMMWk:,,;;;;;;lKWKl;,,:xNXxc;,;:cl:,;kWKl,,lKMMM
MMMMWXOOkkkO0KXNWMMMMWX0O0NMMWKOOKWMWX0kk0XX0O0NMN0O0XWMWKOOKWMMX0O0NMXl,,lO0kkOKWMMMMWX0kkOXNKO0XWWKOOKWMMMMMMMMMN0OkkkOO0KNWMMWXOO0NMMMWX0kkkOKNMMMMMMMMMMMMWNKOkkkO0XWMMMMWKOOKWMMMMWNXK00Kk:,;xNMWXOkk0XK0OKNMX0O0XMMWXOO0NMWKOOKWMMWNKOkkkOXNX0OkkO0XWMMMMMMWX0OOOOOOOO0NMMN0kkOKWMWX0OkOKXKO0XWWKOOKWMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXl,,lXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMKdodxdl:,;oKMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNkookNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXxolcclox0NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWNNWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM";
            Console.SetWindowSize(20, 200);
            Console.SetBufferSize(20, 200);

            Console.ForegroundColor = ConsoleColor.Green;

            string[] lines = background.Split('\n');

            foreach (var line in lines)
            {
                Console.WriteLine(line.Length > Console.WindowWidth
                    ? line.Substring(0, Console.WindowWidth)
                    : line);
            }
            */
            
            while (true)
            {
                var panel = new Panel(
  @" 1: Add Employee
    2: show Employees 
    3: Search Employee
    4: Delete Employee 
    5: show top Employees
    6: Exit"
);

                panel.Header = new PanelHeader("Employees Management System");
                                panel.Border = BoxBorder.Rounded;
                panel.Padding = new Padding(2, 4);
                    AnsiConsole.Write(panel);
                Console.WriteLine("Enter number you want choice :");
                
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Please Enter Only Numbers");
                }
               
                switch (choice)
                {
                    case 1:
                        addEmploye();
                        break;
                    case 2:
                        showemploye();
                        break;

                    case 3:
                        searchemployee();
                        break;

                    case 4:
                        deleteemploye();
                        break;

                    case 5:
                        topemployees();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Default Number:");
                        return;
                }
               
            }
                static void addEmploye()
                {
                    int empid;
                    int salarye;
                    int level; 
                    Employee s = new Employee();


                    Console.WriteLine("Enter Employee Id");
                    while(!int.TryParse(Console.ReadLine(),out empid))
                    {
                        Console.WriteLine("Please Enter Emp Id, Only number :");
                    }
                    bool exist = employees.Any(x => x.emp_id == empid);
                    if (exist)
                    {
                         Console.WriteLine("This Employee Id is already exist, Please try Again :");
                           
                    }
                    s.emp_id = empid;

                    Console.WriteLine("Enter Employee First Name:");
                    s.Name = Console.ReadLine();
                    Console.WriteLine("Enter Employee Last Name:");
                    s.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Employee Salary:");
                    while (!int.TryParse(Console.ReadLine(), out salarye))
                    {
                        Console.WriteLine("Please Enter Salary , Only number: ");
                    }
                    s.salary = salarye ;

                    Console.WriteLine("Enter Employee Deparment: ");

                    s.Department = Console.ReadLine();

                    Console.WriteLine("Enter Employee layer L :");
                    while (!int.TryParse(Console.ReadLine(), out level))
                    {
                        Console.WriteLine("Please Enter Layer ,  Only number: ");
                    }
                    s.Layer =level;

                    employees.Add(s);



                }
                static  void showemploye()
                {
                var cemployee = employees.OrderByDescending(x => x.salary).Select(x => new { x.emp_id, x.Name, x.LastName, x.Department, x.salary, x.Layer, salarytype = x.salary <= 26000 ? "low" : x.salary < 40000 ? "Medium" : "High" });

                Console.Write("Loading Employees");
                for (int i = 0; i < 10; i++)
                {
                    
                    Thread.Sleep(500);
                    Console.Write('.');
                    
                }

                var table = new Table();
                table.Border = TableBorder.Rounded;
                
                table.Title = new TableTitle("\nEmployees List");
                  table.AddColumn("Emp Id");
                table.AddColumn("Emp Name");
                table.AddColumn("Last Name");
                table.AddColumn("Department");
                table.AddColumn("Salary");
                table.AddColumn("Salary Type");
                table.AddColumn("Layer");
                foreach (var item in cemployee)
                    {
                    
                        table.AddRow( 
                            item.emp_id.ToString(),
                            item.Name ,
                    item.LastName,
                    item.Department,
                     item.salary.ToString(),
                    item.salarytype, 
                    $"L{item.Layer}"
                        );
                    }
                
                 Console.ForegroundColor = ConsoleColor.Black;
                  AnsiConsole.Write(table);
                Console.ResetColor();
               

                }



                static void searchemployee()
                {
                    Console.Write("Enter Employee Name:");
                    string Name = Console.ReadLine();
                    
                    var employee = employees.Where(x =>x.Name.Contains(Name));
                
                  foreach(var item in employee)
                    {
                        Console.WriteLine($"{item.emp_id} {item.Name}  {item.LastName} {item.salary}");
                    }


                }
                static void deleteemploye()
                {
                    Console.WriteLine("Enter Employee id :");
                       int id ;
                    while(!int.TryParse(Console.ReadLine(),out id))
                    {
                        Console.WriteLine("Please try Again : Enter EmpId , only Number:");

                    }
                    var employeeg = employees.Where(x=>x.emp_id == id);
                    var deleteid = employees.FirstOrDefault(s => s.emp_id == id);
                    if(employeeg == null || deleteid == null)
                    {
                        Console.WriteLine("Not Found Employee");
                        return;
                    }
                    foreach(var item in employeeg)
                    {
                        Console.WriteLine($"{item.emp_id} {item.Name} {item.Department}");

                    }
                    Console.WriteLine("Are your sure want deleted y/n");
                    string cond = Console.ReadLine();
                    if(cond == "n")
                    {
                        return; 
                    }

                    employees.Remove(deleteid);



                }

                static void topemployees()
                {
                    var employeestop = employees.OrderByDescending(x => x.salary).Take(10);
                var table = new Table();
                table.Border = TableBorder.Rounded;
                table.AddColumn("Emp id");
                table.AddColumn("Emp Name");
                table.AddColumn("Last Name");
                table.AddColumn("Department");
                table.AddColumn("Salary");
                    table.AddColumn("Layer");
                    foreach( var item in employeestop)
                    {
                        table.AddRow(
                            item.emp_id.ToString(),
                            item.Name,
                            item.LastName ,
                            item.Department,
                            item.salary.ToString(),
                            $"{ item.Layer.ToString()} "
                            );

                    }
                AnsiConsole.Write(table);
                }



            }
        }

    
}
