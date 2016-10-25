﻿<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
      <html>
        <body>
          <table>
            <tr>
              <th>Album Name</th>
              <th>Artist</th>
              <th>Year</th>
              <th>Producer</th>
              <th>Price</th>
              <th>Songs</th>
            </tr>
            <xsl:for-each select="catalogue/album">
              <tr>
                <td>
                  <xsl:value-of select="name"/>
                </td>
                <td>
                  <xsl:value-of select="artist"/>
                </td>
                <td>
                  <xsl:value-of select="year"/>
                </td>
                <td>
                  <xsl:value-of select="producer"/>
                </td>
                <td>
                  <xsl:value-of select="price"/>
                </td>
                <td>
                  <xsl:for-each select="songs/song">
                    <div>
                      <strong>
                        <xsl:value-of select="title"/>
                      </strong>
                      <xsl:value-of select="duration"/>
                    </div>
                  </xsl:for-each>
                </td>
              </tr>
            </xsl:for-each>
          </table>
        </body>
      </html>   
    </xsl:template>
</xsl:stylesheet>
