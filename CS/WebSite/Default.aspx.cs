using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Web.ASPxGridView;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        ASPxGridView1.DataSource = Enumerable.Range(0, 10).Select(i => new { ID = i, Text =  i%2 == 0 ? "Group 1" : "Group 2"});
        if (!IsPostBack)
            ASPxGridView1.DataBind();
        ASPxGridView1.ExpandAll();
    }

    public string GetSummaryValue(GridViewGroupRowTemplateContainer c) {
        var grid = c.Grid;
        var summary = grid.GroupSummary["ID"];
        var sumValue = grid.GetGroupSummaryValue(c.VisibleIndex, summary);
        return sumValue.ToString();
    }
}