<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
            <head>
                <title>Students</title>
            </head>
            <body>
                <xsl:for-each select="/students/student">
                    <p>Student: </p>
                    <ul>
                        <li>
                            <xsl:value-of select="@id" />
                        </li>
                        <li>
                            <xsl:value-of select="fname" />
                        </li>
                        <li>
                            <xsl:value-of select="lname" />
                        </li>
                        <li>
                            <a>
                                <xsl:attribute name="href">
                                    mailto:
                                    <xsl:value-of select="email" />
                                </xsl:attribute>
                                <xsl:value-of select="email" />
                            </a>
                        </li>
                    </ul>
                </xsl:for-each>
                
                <p>
                    Number of students in document: <xsl:value-of select="count(/students/student)" />
                </p>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>