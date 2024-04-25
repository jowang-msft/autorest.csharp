// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

import { DecoratedType, Operation, Program, Type } from "@typespec/compiler";
import { ExternalDocs } from "../type/externalDocs.js";
import { SdkContext } from "@azure-tools/typespec-client-generator-core";

const externalDocsKey = Symbol("externalDocs");
export function getExternalDocs(
    context: SdkContext,
    entity: Type
): ExternalDocs | undefined {
    return context.program.stateMap(externalDocsKey).get(entity);
}

const operationIdsKey = Symbol("operationIds");
/**
 * @returns operationId set via the @operationId decorator or `undefined`
 */
export function getOperationId(
    context: SdkContext,
    entity: Operation
): string | undefined {
    return context.program.stateMap(operationIdsKey).get(entity);
}

export function hasDecorator(type: DecoratedType, name: string): boolean {
    return (
        type.decorators.find((it) => it.decorator.name === name) !== undefined
    );
}

//ACSHACK
export const $property = (
    context: SdkContext,
    entity: Operation,
    verb: string
) => {
    const { program } = context;
  
    program.stateMap(Symbol.for(entity.name)).set(entity, verb);
};

//ACSHACK
export const $event = (
    context: SdkContext,
    entity: Operation
) => {
    const { program } = context;
    program.stateMap(Symbol.for(entity.name)).set(entity, "");
};
