<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Evaluate.aspx.cs" Inherits="CES.UI.Pages.EvaluationManagement.Evaluate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" runat="server" AutoSizePanelID="Panel1" />
    <x:Panel ID="Panel1" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
        Title="Panel" Layout="Fit">
        <Items>
            <x:Panel ID="Panel2" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
                Title="Panel" AutoScroll="true">
                <Items>
                    <x:Toolbar ID="Toolbar1" runat="server">
                        <Items>
                            <x:Button ID="Button_Refresh" runat="server" Text="刷新">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator1" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button_Submit" runat="server" Text="提交">
                            </x:Button>
                        </Items>
                    </x:Toolbar>
                    <x:Panel ID="Panel3" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false"
                        Title="Panel">
                        <Items>
                            <x:SimpleForm ID="SimpleForm1" runat="server" BodyPadding="5px" Title="SimpleForm"
                                ShowBorder="false" ShowHeader="false">
                                <Items>
                                    <x:Label ID="Label1" runat="server" Label="当前考评状态" Text="***">
                                    </x:Label>
                                </Items>
                            </x:SimpleForm>
                            <x:Grid ID="Grid1" runat="server" Title="被考评人名单">
                                <Columns>
                                    <x:BoundField Width="100px" DataField="ID" DataFormatString="{0}" HeaderText="工号"
                                        Hidden="false" />
                                    <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="姓名"
                                        Hidden="false" />
                                    <x:BoundField Width="50px" DataField="Sex" DataFormatString="{0}" HeaderText="性别"
                                        Hidden="false" />
                                    <x:BoundField Width="200px" DataField="Job" DataFormatString="{0}" HeaderText="职务"
                                        Hidden="false" />
                                    <x:BoundField Width="150px" DataField="Status" DataFormatString="{0}" HeaderText="当前状态"
                                        Hidden="false" />
                                </Columns>
                            </x:Grid>
                        </Items>
                    </x:Panel>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    </form>
</body>
</html>
