namespace ScriptedUI

open canopy
open System

type CanopyTest() =
    do
        configuration.chromeDir <- "."
        configuration.ieDir <- "."
        configuration.elementTimeout <- 1.
        configuration.pageTimeout <- 3.
        configuration.autoPinBrowserRightOnLaunch <- false
        configuration.optimizeByDisablingClearBeforeWrite <- true
        configuration.optimizeByDisablingCoverageReport <- true
        configuration.optimizeBySkippingIFrameCheck <- true

        start chrome

    interface IDisposable with
        member __.Dispose() = quit ()