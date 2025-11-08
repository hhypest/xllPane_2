namespace xllPane.Shared.Data

open System

type ErrorMessage =
    {
        Message: string
        Source: string
        ErrorUtc: DateTime
    }