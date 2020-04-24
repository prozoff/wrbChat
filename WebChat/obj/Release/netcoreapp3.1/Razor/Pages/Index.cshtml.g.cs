#pragma checksum "C:\Users\Lenovo\source\repos\WebChat\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f5e212dc74332986bd6ac7538669ffbe938da97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f5e212dc74332986bd6ac7538669ffbe938da97", @"/Pages/Index.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

<div class=""container"" align=""center");
            WriteLiteral(@""">
    <div id=""loginBlock"" align=""center"">
        Name:<br />
        <input id=""userName"" type=""text"" />
        <input id=""loginBtn"" type=""button"" class=""btn btn-sm btn-secondary"" style=""width:70px;height:30px"" value=""Rename"" />
    </div>
    <br />
    <div id=""inputForm"" align=""center"">
        <input type=""text"" id=""message"" autofocus/>
        <input type=""submit"" class=""btn btn-sm btn-secondary"" style=""width:70px;height:30px"" id=""sendBtn"" value=""Send"" />
    </div>
    <div id=""chatroom"" align=""center""></div>

</div>

<script src=""js/signalr/dist/browser/signalr.min.js""></script>
<script>
    const hubConnection = new signalR.HubConnectionBuilder()
        .withUrl(""/chat"")
        .build();

    let generateId = 1;
    let userName = 'Anonymous';
    let oldUserName = null;
    if (get_cookie(""user"") == null) {
        userName = 'Anonymous';
        document.getElementById(""userName"").value = 'Anonymous';
    } else {
        userName = get_cookie(""user"");
        docu");
            WriteLiteral(@"ment.getElementById(""userName"").value = userName;
    }

    hubConnection.on('Send', function (message, messageUserName) {
        let messageNew = document.createElement(""div"");

        if (userName == messageUserName) {
            
            messageNew.id = generateId;
            messageNew.align = ""right"";

            let btnEdit = document.createElement(""value"");
            btnEdit.setAttribute('type', ""button"");
            btnEdit.id = ""btn_"" + generateId;
            btnEdit.setAttribute('class', ""btn btn-sm btn-outline-secondary"");
            btnEdit.setAttribute('onclick', ""editMassage(this.id)"");
            btnEdit.innerHTML = ""edit"";

            let btnDelete = document.createElement(""value"");
            btnDelete.setAttribute('type', ""button"");
            btnDelete.id = ""btnDel_"" + generateId;
            btnDelete.setAttribute('class', ""btn btn-sm btn-outline-danger"");
            btnDelete.setAttribute('onclick', ""deleteText(this.id)"");
            btnDelete.i");
            WriteLiteral(@"nnerHTML = ""delete"";

            let messageBlock = document.createElement(""span"");
            messageBlock.id = ""msg_"" + generateId;
            messageBlock.innerHTML = message;

            let nameBlock = document.createElement(""span"");
            nameBlock.id = ""nameId_"" + generateId;
            nameBlock.innerHTML = "" : "" + messageUserName + "" "";

            messageNew.prepend(messageBlock);
            messageNew.append(nameBlock);
            messageNew.append(btnEdit);
            messageNew.append(btnDelete);
            
        } else {

            let messageBlock = document.createElement(""span"");
            messageBlock.id = ""msg_"" + generateId;
            messageBlock.innerHTML = message;

            let nameBlock = document.createElement(""span"");
            nameBlock.id = ""nameId_"" + generateId;
            nameBlock.innerHTML = "" "" + messageUserName + "" : "";

            messageNew.id = generateId;
            messageNew.align = ""left"";
            message");
            WriteLiteral(@"New.append(messageBlock);
            messageNew.prepend(nameBlock);
        }
        let firstElem = document.getElementById(""chatroom"").firstChild;
        document.getElementById(""chatroom"").insertBefore(messageNew, firstElem);
        generateId++;
    });

    function editMassage(btnId) {
        let mainId = btnId.slice(4);
        let editedMessageId = ""msg_"" + mainId;
        let editBlock = document.getElementById(editedMessageId);
        let editBtn = document.getElementById(btnId);
        let mainBlock = document.getElementById(mainId);
        let savededMessage = document.getElementById(editedMessageId).innerHTML;
        document.getElementById(""btnDel_"" + mainId).remove();
        editBlock.remove();
        editBtn.remove()

        let saveBtn = document.createElement(""value"");
        saveBtn.setAttribute('type', ""button"");
        saveBtn.id = ""save_"" + mainId;
        saveBtn.setAttribute('class', ""btn btn-sm btn-outline-secondary"");
        saveBtn.setAttribute(");
            WriteLiteral(@"'onclick', ""saveChange(this.id)"")
        saveBtn.innerHTML = ""save"";
        mainBlock.append(saveBtn);

        let editField = document.createElement(""input"")
        editField.id = ""editField"";
        editField.type = ""text"";
        editField.value = savededMessage;
        mainBlock.prepend(editField);

    }

    function saveChange(btnId) {

        let changedMessages = document.getElementById(""editField"").value;
        let mainId = btnId.slice(5);
        let saveBtn = document.getElementById(btnId);
        let editField = document.getElementById(""editField"")
        saveBtn.remove();
        editField.remove();

        let mainBlock = document.getElementById(mainId);
        let messageBlock = document.createElement(""span"");
        messageBlock.id = ""msg_"" + mainId;
        messageBlock.innerHTML = changedMessages;
        mainBlock.prepend(messageBlock);

        let btnEdit = document.createElement(""value"");
        btnEdit.setAttribute('type', ""button"");
       ");
            WriteLiteral(@" btnEdit.id = ""btn_"" + mainId;
        btnEdit.setAttribute('class', ""btn btn-sm btn-outline-secondary"");
        btnEdit.setAttribute('onclick', ""editMassage(this.id)"")
        btnEdit.innerHTML = ""edit"";
        mainBlock.append(btnEdit);

        let btnDelete = document.createElement(""value"");
        btnDelete.setAttribute('type', ""button"");
        btnDelete.id = ""btnDel_"" + mainId;
        btnDelete.setAttribute('class', ""btn btn-sm btn-outline-danger"");
        btnDelete.setAttribute('onclick', ""deleteText(this.id)"");
        btnDelete.innerHTML = ""delete"";
        mainBlock.append(btnDelete);

        hubConnection.invoke(""editText"", changedMessages, mainId, userName)
    }

    hubConnection.on(""editText"", function (message, id, messageUserName) {
        if (userName != messageUserName) {
            let editedText = document.getElementById(""msg_"" + id);
            editedText.innerHTML = message;
        }
    });

    function deleteText(btnId) {
        let mainId = btnI");
            WriteLiteral(@"d.slice(7);
        hubConnection.invoke(""deleteMessage"", mainId)
    }

    hubConnection.on(""deleteMessage"", function (mainId) {
        document.getElementById(mainId).remove();
    });

    addEventListener(""keydown"", hifun);
    function hifun(e) {
        if (e.keyCode == 13) {
            let message = document.getElementById(""message"").value;
            document.getElementById(""message"").value = '';
            document.getElementById(""message"").focus();
            hubConnection.invoke(""Send"", message, userName);
        }
    }

    hubConnection.on(""sendNewName"", function (oldName, newName) {
        if (oldUserName == oldName) {
            for (let i = 1; i < generateId; i++) {
                let chekedBlock = document.getElementById(""nameId_"" + i);
                if (chekedBlock.innerHTML.slice(3) == oldName + "" "") {
                    chekedBlock.innerHTML = "" : "" + newName + "" "";
                }
            }
        } else {
            for (let i = 1; i < gen");
            WriteLiteral(@"erateId; i++) {
                let chekedBlock = document.getElementById(""nameId_"" + i);
                if (chekedBlock.innerHTML.slice(1) == oldName + "" : "") {
                    chekedBlock.innerHTML = "" "" + newName + "" : "";
                }
            }
        }
        
    })

    document.getElementById(""loginBtn"").addEventListener(""click"", function (e) {
        let oldName = userName;
        oldUserName = userName;
        userName = document.getElementById(""userName"").value;
        document.cookie = ""user="" + userName + ""; max - age=7200"";
        hubConnection.invoke(""sendNewName"", oldName, userName)
    });

    
    document.getElementById(""sendBtn"").addEventListener(""click"", function(e) {
        let message = document.getElementById(""message"").value;
        document.getElementById(""message"").value = '';
        document.getElementById(""message"").focus();
        hubConnection.invoke(""Send"", message, userName);
    });


    function get_cookie(cookie_name) {
");
            WriteLiteral("        let results = document.cookie.match(\'(^|;) ?\' + cookie_name + \'=([^;]*)(;|$)\');\r\n\r\n        if (results)\r\n            return (unescape(results[2]));\r\n        else\r\n            return null;\r\n    }\r\n\r\n\r\n    hubConnection.start();\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebChat.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebChat.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebChat.Pages.IndexModel>)PageContext?.ViewData;
        public WebChat.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
