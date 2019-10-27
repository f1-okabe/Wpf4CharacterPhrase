using ExtensionsLibrary;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4CharacterPhrase.Blazor.Pages
{
    public class FetchDataBase :  ComponentBase
    {
        public BordEntity Bord { get; set; } = new BordEntity();

        public string Message { get; set; } = "";

        protected override void OnInitialized()
        {
            Bord.SetData();
        }

        protected void BordClick(CellEntity cell)
        {
            Bord.Click(cell);

            if (Bord.IsCompleted() == true)
            {
                Message = "Completed";
            }

            StateHasChanged();
        }

        protected string GetCss(CellStatus cellStatus)
        {
            switch (cellStatus)
            {
                case CellStatus.None:
                    return "btn btn-info";
                case CellStatus.Selecting:
                    return "btn btn-primary";
                case CellStatus.Completed:
                    return "btn btn-success";
                default:
                    return "btn btn-info";
            }
            
        }
    }
}

