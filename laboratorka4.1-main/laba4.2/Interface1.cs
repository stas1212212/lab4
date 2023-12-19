using System;
using System.Collections.Generic;

// Інтерфейс для з'єднання та передачі даних
public interface IConnectable
{
    void Connect(IConnectable device);
    void Disconnect(IConnectable device);
    void TransferData(IConnectable device, string data);
}