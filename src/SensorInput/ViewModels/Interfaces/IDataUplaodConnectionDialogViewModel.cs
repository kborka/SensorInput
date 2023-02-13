using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorInput.ViewModels.Interfaces;
public interface IDataUplaodConnectionDialogViewModel
{
    IDataUploadConnectionInfoViewModel DatabaseConnectionInfo { get; }
}
