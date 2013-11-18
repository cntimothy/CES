<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendMsg.aspx.cs" Inherits="CES.UI.Pages.MsgManagement.SendMsg" %>

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
                Title="Panel">
                <Items>
                    <x:Toolbar ID="Toolbar1" runat="server">
                        <Items>
                            <x:Button ID="Button_Refresh" runat="server" Text="刷新">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator1" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button_Send" runat="server" Text="发送">
                            </x:Button>
                        </Items>
                    </x:Toolbar>
                    <x:Panel ID="Panel3" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false"
                        Title="Panel" Layout="Column">
                        <Items>
                            <x:Grid ID="Grid1" runat="server" Title="员工名单" AllowPaging="true" PageSize="20" EnableRowNumber="true"
                                Height="520px" AutoScroll="true" DataKeyNames="ID" EnableCheckBoxSelect="true"
                                CheckBoxSelectOnly="true" OnPageIndexChange="Grid1_PageIndexChange" ClearSelectedRowsAfterPaging="false"
                                Width="800px">
                                <Columns>
                                    <x:BoundField Width="150px" DataField="ID" DataFormatString="{0}" HeaderText="工号"
                                        Hidden="true" />
                                    <x:BoundField Width="200px" DataField="Name" DataFormatString="{0}" HeaderText="姓名"
                                        Hidden="true" />
                                    <x:BoundField Width="50px" DataField="Sex" DataFormatString="{0}" HeaderText="性别"
                                        Hidden="true" />
                                    <x:BoundField Width="200px" DataField="Job" DataFormatString="{0}" HeaderText="职务"
                                        Hidden="true" />
                                    <x:BoundField Width="150px" DataField="Role" DataFormatString="{0}" HeaderText="分类"
                                        Hidden="true" />
                                    <x:BoundField Width="300px" DataField="Tele" DataFormatString="{0}" HeaderText="电话"
                                        Hidden="true" />
                                </Columns>
                            </x:Grid>
                            <x:TextArea ID="TextArea1" runat="server" Label="Label" Text="" Width="300px" Height="200px" EmptyText="请输入短信内容，系统将在短信后面自动加上用户名和密码。">
                            </x:TextArea>
                        </Items>
                    </x:Panel>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    </form>
</body>
</html>
