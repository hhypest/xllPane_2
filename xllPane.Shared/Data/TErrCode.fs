namespace xllPane.Shared.Data

open System

type ErrMessage =
    {
        Message: string
        Source: string
        ErrUtc: DateTime
    }