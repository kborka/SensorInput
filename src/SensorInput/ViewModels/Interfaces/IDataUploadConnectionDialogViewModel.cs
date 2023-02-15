using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorInput.ViewModels.Interfaces;
public interface IDataUploadConnectionDialogViewModel
{
    IDataUploadConnectionInfoViewModel DataUploadConnectionInfo { get; }
}
