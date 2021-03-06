/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 */

'use strict';

/**
 * Class of paths for streaming
 *
 */
class StreamingPath {
  /**
   * Create a StreamingPath.
   * @member {string} streamingProtocol Streaming protocol. Possible values
   * include: 'Hls', 'Dash', 'SmoothStreaming', 'Download'
   * @member {string} encryptionScheme Encryption scheme. Possible values
   * include: 'NoEncryption', 'EnvelopeEncryption', 'CommonEncryptionCenc',
   * 'CommonEncryptionCbcs'
   * @member {array} [paths] Streaming paths for each protocol and
   * encryptionScheme pair
   */
  constructor() {
  }

  /**
   * Defines the metadata of StreamingPath
   *
   * @returns {object} metadata of StreamingPath
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'StreamingPath',
      type: {
        name: 'Composite',
        className: 'StreamingPath',
        modelProperties: {
          streamingProtocol: {
            required: true,
            serializedName: 'streamingProtocol',
            type: {
              name: 'String'
            }
          },
          encryptionScheme: {
            required: true,
            serializedName: 'encryptionScheme',
            type: {
              name: 'String'
            }
          },
          paths: {
            required: false,
            serializedName: 'paths',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'StringElementType',
                  type: {
                    name: 'String'
                  }
              }
            }
          }
        }
      }
    };
  }
}

module.exports = StreamingPath;
