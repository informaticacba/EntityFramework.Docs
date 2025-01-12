﻿public class Program
{
    public static void Main()
    {
        // Note: These samples requires the Cosmos DB emulator to be installed and running
        CosmosPrimitiveTypesSample.Collections_and_dictionaries_of_primitive_types();
        CosmosQueriesSample.Cosmos_queries();
        CosmosDiagnosticsSample.Cosmos_diagnostics();
        CosmosModelConfigurationSample.Cosmos_configure_time_to_live();
    }
}
