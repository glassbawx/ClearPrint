Module Module1

    Sub Main()
        Dim service As ServiceProcess.ServiceController = New ServiceProcess.ServiceController("Print Spooler")
        If ((service.Status.Equals(ServiceProcess.ServiceControllerStatus.Running)) Or
                (service.Status.Equals(ServiceProcess.ServiceControllerStatus.Paused))) Then
            service.Stop()
            Kill("C:\Windows\System32\spool\PRINTERS\*.*")
            service.Start()
        Else
            service.Start()

        End If
    End Sub
End Module
