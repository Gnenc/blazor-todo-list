#pragma checksum "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d87cbb28684fb8c0aeb4494cb6afee72a46913e8"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/gonenc/Desktop/test_app/Blazor/TodoList/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/gonenc/Desktop/test_app/Blazor/TodoList/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/gonenc/Desktop/test_app/Blazor/TodoList/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/gonenc/Desktop/test_app/Blazor/TodoList/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/gonenc/Desktop/test_app/Blazor/TodoList/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/gonenc/Desktop/test_app/Blazor/TodoList/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/gonenc/Desktop/test_app/Blazor/TodoList/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/gonenc/Desktop/test_app/Blazor/TodoList/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/gonenc/Desktop/test_app/Blazor/TodoList/_Imports.razor"
using TodoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/gonenc/Desktop/test_app/Blazor/TodoList/_Imports.razor"
using TodoList.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/gonenc/Desktop/test_app/Blazor/TodoList/_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
using TodoList.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todoTable")]
    public partial class TodoTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TodoTable</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-4");
            __Blazor.TodoList.Pages.TodoTable.TypeInference.CreateMatTextField_0(__builder, 5, 6, "Add todo task here", 7, 
#nullable restore
#line 9 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
                                    myTodoText

#line default
#line hidden
#nullable disable
            , 8, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => myTodoText = __value, myTodoText)), 9, () => myTodoText);
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-4");
            __Blazor.TodoList.Pages.TodoTable.TypeInference.CreateMatDatePicker_1(__builder, 13, 14, 
#nullable restore
#line 12 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
                                     myDeadLine

#line default
#line hidden
#nullable disable
            , 15, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => myDeadLine = __value, myDeadLine)), 16, () => myDeadLine);
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-md-4");
            __builder.OpenComponent<MatBlazor.MatButton>(20);
            __builder.AddAttribute(21, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "Icon", "playlist_add");
            __builder.AddAttribute(23, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
                                                               Click

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n            Add Todo\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
 if (Todos != null && Todos.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "table");
            __builder.AddAttribute(27, "class", "table");
            __builder.AddMarkupContent(28, "<thead><tr><th>Ready ?</th>\r\n            <th>Description</th>\r\n            <th>Deadline</th>\r\n            <th>Complete</th>\r\n            <th>Delete</th>\r\n            <th>Edit</th></tr></thead>\r\n    ");
            __builder.OpenElement(29, "tbody");
#nullable restore
#line 35 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
         foreach (var td in Todos)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "tr");
            __builder.OpenElement(31, "td");
            __Blazor.TodoList.Pages.TodoTable.TypeInference.CreateMatCheckbox_2(__builder, 32, 33, 
#nullable restore
#line 39 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
                                                                             true

#line default
#line hidden
#nullable disable
            , 34, 
#nullable restore
#line 39 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
                                                   td.IsCompleted

#line default
#line hidden
#nullable disable
            , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => td.IsCompleted = __value, td.IsCompleted)), 36, () => td.IsCompleted);
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 42 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
                         td.Todo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 45 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
                         td.Deadline.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "td");
            __builder.OpenComponent<MatBlazor.MatButton>(45);
            __builder.AddAttribute(46, "Icon", "done");
            __builder.AddAttribute(47, "Outlined", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
                                                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
                                                                           e => completeItem(td.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(50, "Complete");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "td");
            __builder.OpenComponent<MatBlazor.MatButton>(53);
            __builder.AddAttribute(54, "Icon", "delete");
            __builder.AddAttribute(55, "Outlined", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
                                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
                                                                             e => deleteItem(td.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(58, "Delete");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "td");
            __builder.OpenComponent<MatBlazor.MatButton>(61);
            __builder.AddAttribute(62, "Icon", "edit");
            __builder.AddAttribute(63, "Outlined", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
                                                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
                                                                           e => editItem(td.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(66, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "/home/gonenc/Desktop/test_app/Blazor/TodoList/Pages/TodoTable.razor"
       
    private List<TodoModel> Todos = new List<TodoModel>();
    string myTodoText = null;
    DateTime? myDeadLine;
    int editedId = 0;

    private void Click(MouseEventArgs e)
    {
        if (myTodoText == null)
        {
            Toaster.Add("Cannot add empty values.", MatToastType.Warning, "Todo List", null);
            return;
        }

        if (editedId == 0)
        {
            var myTodoItem = new TodoModel()
            {
                Id = Todos.Count() + 1,
                Deadline = myDeadLine == null ? DateTime.Now.AddDays(1) : ((DateTime)myDeadLine),
                Todo = myTodoText,
                IsCompleted = false
            };
            Todos.Add(myTodoItem);
            myTodoText = null;
            myDeadLine = null;
            Toaster.Add("New todo added.", MatToastType.Info, "Todo List", null);
        }
        else
        {
            var myTodo = Todos.FirstOrDefault(x => x.Id == editedId);
            myTodo.Todo = myTodoText;
            myTodo.Deadline = myDeadLine == null ? DateTime.Now.AddDays(1) : ((DateTime)myDeadLine);

            myTodoText = null;
            myDeadLine = null;
            Toaster.Add("Todo edit finished.", MatToastType.Info, "Todo List", null);
            editedId = 0;
        }
    }

    private void deleteItem(int id)
    {
        var myTodo = Todos.FirstOrDefault(x => x.Id == id);
        Todos.Remove(myTodo);
        Toaster.Add("Todo removed.", MatToastType.Info, "Todo List", null);
    }

        private void completeItem(int id)
    {
        var myTodo = Todos.FirstOrDefault(x => x.Id == id);
        myTodo.IsCompleted = !myTodo.IsCompleted;
        Toaster.Add("Todo status changed.", MatToastType.Info, "Todo List", null);
    }

        private void editItem(int id)
    {
        var myTodo = Todos.FirstOrDefault(x => x.Id == id);
        myTodoText = myTodo.Todo;
        myDeadLine = myTodo.Deadline;
        editedId = id;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
    }
}
namespace __Blazor.TodoList.Pages.TodoTable
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::MatBlazor.MatDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateMatCheckbox_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatCheckbox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Disabled", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
