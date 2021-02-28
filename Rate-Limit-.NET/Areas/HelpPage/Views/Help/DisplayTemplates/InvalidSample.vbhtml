@Imports Rate_Limit_.NET.Areas.HelpPage
@ModelType InvalidSample

@If HttpContext.Current.IsDebuggingEnabled Then
    @<div class="warning-message-container">
        <p>@Model.ErrorMessage</p>
    </div>
Else
    @<p>Sample not available.</p>
End If