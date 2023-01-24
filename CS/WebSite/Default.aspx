<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxGridView ID="ASPxGridView1" runat="server" KeyFieldName="ID">
            <Columns>
                <dx:GridViewDataTextColumn FieldName="ID"></dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Text" GroupIndex="0"></dx:GridViewDataTextColumn>
            </Columns>
            <Templates>
                <GroupRowContent>
                    <%# Container.GroupText + ", Summary value: " + GetSummaryValue(Container) %>
                </GroupRowContent>
            </Templates>
            <GroupSummary>
                <dx:ASPxSummaryItem FieldName="ID" SummaryType="Sum" />
            </GroupSummary>
        </dx:ASPxGridView>
    </div>
    </form>
</body>
</html>
